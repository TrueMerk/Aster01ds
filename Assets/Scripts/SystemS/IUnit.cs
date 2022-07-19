
public interface IUnit 
{
    IUnitType UnitType  { get; set; }
}

public enum IUnitType
{
    Friend,
    Enemy,
    UFO
}