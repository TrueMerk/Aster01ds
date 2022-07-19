using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private int _poolCount = 3;
    [SerializeField] private bool _autoExpand = true;
    [SerializeField] private BulletDamageDealer _bulletPrefab;
    
    
    private Pool<BulletDamageDealer> _pool;

    private void Start()
    {
        _pool = new Pool<BulletDamageDealer>(_bulletPrefab, _poolCount, transform)
        {
            AutoExpand = _autoExpand
        };
        
    }
    
    public void CreateBullet(Transform shotDir)
    {
        var bullet = _pool.GetFreeElement();
        var o = bullet.gameObject;
        o.transform.position = shotDir.position;
        o.transform.rotation = shotDir.rotation;
    }

    public void GiveTarget()
    {
        
    }
}
