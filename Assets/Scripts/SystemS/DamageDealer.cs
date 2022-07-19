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
        
        var unitType = other.GetComponent<IUnit>().UnitType;
        var shooterSpawn = other.GetComponent<ShooterSpawnType>();
        var tShooterSpawn = GetComponent<ShooterSpawnType>();
        if (UnitType != unitType)
            {
                if (damagableComponent != null)
                {
                    DealDamage(damagableComponent);
                }
            }
        
    }
}