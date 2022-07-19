using System;
using UnityEngine;
using DefaultNamespace;

public class Health : MonoBehaviour, IDamagable
{
   [SerializeField] private GameObject _explosion;
   [SerializeField] protected int  _health;
   [SerializeField] private IUnitType _unitType;
   public  IUnitType UnitType { get; set; }
    
    public  event Action OnHealthLeftEvent;

    private void Start()
    {
        UnitType = _unitType;
    }

    public void ReceiveDamage(IDamageDealer damageDealer,int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {   
            OnHealthLeft();
        }
    }

    public void DeathI(IDamageDealer damageDealer)
    {
        _health = 0;
        OnHealthLeft();
    }
    
    private void OnHealthLeft()
    {
        Instantiate(_explosion, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        OnHealthLeftEvent?.Invoke();
       
        
    }
    
}