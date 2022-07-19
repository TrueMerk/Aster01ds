using System;
using UnityEngine;

public class BulletDamageDealer : DamageDealer
{
    public override IUnitType UnitType { get; set; }
    [SerializeField] private IUnitType _unitType;

    private void Start()
    {
        UnitType = IUnitType.Friend;
        UnitType = _unitType;
    }

   
}
