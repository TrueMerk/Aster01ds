using System;
using UnityEngine;

public class ShooterSpawnType : MonoBehaviour, IUnit
{
    public IUnitType UnitType { get; set; }
    [SerializeField] private IUnitType _unitType;


    private void Start()
    {
        UnitType = _unitType;
    }
}
