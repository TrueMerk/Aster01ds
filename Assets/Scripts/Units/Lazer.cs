using System;
using System.Collections;
using DefaultNamespace;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public  class Lazer : Weapon
{
    [SerializeField] private float _lazerAmount;
    [SerializeField] private Transform _shooterSpawn;
    [SerializeField] private GameObject _lazer;
    [SerializeField] private float _laserReload;
    
    public override void CanShoot()
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        GameData.laserAmount = _lazerAmount;
    }

    private void Start()
    {
        StartCoroutine(LaserReload(_laserReload));
    }

    public override void Shoot()
    {
        if (_lazerAmount != 0)
        {
            Instantiate(_lazer, _shooterSpawn.position, _shooterSpawn.rotation);
            _lazerAmount--;
            GameData.laserAmount = _lazerAmount;
        }
    }
    
    private IEnumerator LaserReload(float rate)
    {
        while (true)
        {
            _lazerAmount++;    
            yield return new WaitForSeconds(rate);
        }
    }
}
