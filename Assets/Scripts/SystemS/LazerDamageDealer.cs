using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public  class LazerDamageDealer : DamageDealer
{
    public override IUnitType UnitType { get; set; }
    
}