using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class DamageDealer : MonoBehaviour, IDamageDealer
{
    [SerializeField] private int _damageAmount;
    public abstract IUnitType UnitType { get; set; }
    public int DamageAmount => _damageAmount;

    private void DealDamage(IDamagable damageReceiver)
    {
        damageReceiver.ReceiveDamage(this,_damageAmount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        var damagableComponent = other.GetComponent<IDamagable>();
        if (other.GetComponent<IUnit>()!=null)
        {
            var unitType = other.GetComponent<IUnit>().UnitType;
            if (UnitType != unitType)
            {
                if (damagableComponent != null)
                {
                    DealDamage(damagableComponent);
                }
            }
        }
       
        
    }
}