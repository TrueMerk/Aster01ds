using System;
using System.Collections;
using UnityEngine;

public class UFOShooter : MonoBehaviour
{

    [SerializeField] private BulletDamageDealer _bulletPrefab;
    [SerializeField] private BulletPool _bullet;
    [SerializeField] public Transform _shotDir;
    [SerializeField] private float _shootRate;
    
    private float _reload;

    private void Start()
    {
        _reload = 2;
      
    }

    private void Update()
    {
        if (_reload > 0)
        {
            _reload -= Time.deltaTime;
        }

        if (_reload < 0)
        {
            _reload = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        var unitType = other.GetComponent<IUnit>().UnitType;
        var damagableComponent = other.GetComponent<IDamagable>();
       
        if (unitType == IUnitType.Friend)
        {
            if (damagableComponent != null)
            {
                var difference = other.transform.position - _shotDir.position;
                var rotateZ = Math.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                var target = Quaternion.Euler(0f,0f,((float) (rotateZ) - 100));
                _shotDir.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * 100);
                if (_reload == 0)
                {
                    _bullet.CreateBullet(_shotDir);
                    _reload = _shootRate;
                }
                
            }
        }
    }

    private IEnumerator ShootCoroutine(float rate)
    {

        while (true)
        {
            _bullet.CreateBullet(_shotDir);
            yield return new WaitForSeconds(rate);
        }

    }
}
