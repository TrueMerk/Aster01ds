public interface IDamagable : IUnit 
{
    void ReceiveDamage(IDamageDealer damageDealer, int damage);
    void DeathI(IDamageDealer damageDealer);
}

public interface IDamageDealer : IUnit
{
    public int DamageAmount { get; }
}