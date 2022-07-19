using UnityEngine;

public class AsteroidDamageDealer : DamageDealer
{
    public override IUnitType UnitType { get; set; }
    
    public void Start()
    {
        UnitType = IUnitType.Enemy;
    }
}
