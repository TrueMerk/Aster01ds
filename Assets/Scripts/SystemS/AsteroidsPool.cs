using System.Collections;
using DefaultNamespace;
using UnityEngine;

public class AsteroidsPool : MonoBehaviour
{
    [SerializeField] private int _poolCount = 2;
    [SerializeField] private bool _autoExpand = true;
    [SerializeField] private BigAsteroid _asteroidPrefab;
    private Pool <BigAsteroid> _pool;

    private void Start()
    {
        _pool = new Pool <BigAsteroid> (_asteroidPrefab, _poolCount, transform)
        {
            AutoExpand = _autoExpand
        };
        
        StartCoroutine(SpawnAsteroidsCoroutine(2));
    }

   

    private void CreateAsteroid()
    {
        var rX = Random.Range(-9f, 7f);
        var rY = Random.Range(-2f,8f);
        var rPosition = new Vector3(rX, rY, 0);

        var asteroid = _pool.GetFreeElement();
        asteroid.transform.position = rPosition;
    }
    
    private IEnumerator SpawnAsteroidsCoroutine(float rate)
    {
        
        while (true)
        {
            
            if (GameData._asteroidCounter == 0)
            {
                Debug.Log("Заспавнить астероиды");
                for (var i = 0; i < _poolCount; i++)
                {
                    CreateAsteroid();
                    GameData._asteroidCounter++;
                }

                _poolCount++;
            }
            
            yield return new WaitForSeconds(rate);
        }
        
        // ReSharper disable once IteratorNeverReturns
    }

}
