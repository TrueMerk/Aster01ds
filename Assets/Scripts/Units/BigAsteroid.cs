using DefaultNamespace;
using UnityEngine;

public class BigAsteroid : MonoBehaviour, IUnit
{
    [SerializeField] public AsteroidMover _gameObjectAsteroid;
    [SerializeField] private Health _health;
    [SerializeField] private IUnitType _unitType;
    [SerializeField] private int _score ;
    private int _poolCount = 2;
    private bool _autoExpand = true;
    private Pool <AsteroidMover> _pool;
    public IUnitType UnitType { get; set; }
    
    private void Start()
    {
        _pool = new Pool <AsteroidMover> (_gameObjectAsteroid, _poolCount, transform)
        {
            AutoExpand = _autoExpand
        };
        UnitType = _unitType;
        _health.OnHealthLeftEvent += OnHealthLeft;
    }
    
    private void OnHealthLeft()
    {
        var position = _gameObjectAsteroid.transform.position;
        CreateAsteroid(45);
        CreateAsteroid(-45);
        GameData.score+= _score;
        GameData._asteroidCounter += 2;
        GameData._asteroidCounter--;
    }

    private void CreateAsteroid(int q)
    {
        var asteroid = _pool.GetFreeElement();
        asteroid.transform.position = transform.position;
        asteroid.transform.rotation = Quaternion.Euler(transform.rotation.x+q, 0, 0) ;
    }

    
}
