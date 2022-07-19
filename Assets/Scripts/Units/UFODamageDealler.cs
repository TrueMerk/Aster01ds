public class UFODamageDealler : DamageDealer
{
    public override IUnitType UnitType { get; set; }

    private void Start()
    {
        UnitType = IUnitType.UFO;
    }
}
