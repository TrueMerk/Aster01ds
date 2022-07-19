using System.Collections;
using DefaultNamespace;
using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    [SerializeField] private int _poolCount = 3;
    [SerializeField] private bool _autoExpand = true;
    [SerializeField] private UFOMover _UFOPrefab;
    private Pool <UFOMover> _pool;

    private void Start()
    {
        _pool = new Pool <UFOMover> (_UFOPrefab, _poolCount, transform)
        {
            AutoExpand = this._autoExpand
        };
        
        StartCoroutine(SpawnUFOCoroutine(20));
    }

   

    private void CreateUFO()
    {
        var rX = Random.Range(-9f, 7f);
        var rY = Random.Range(-2f,8f);
        var rPosition = new Vector3(rX, rY, 0);

        var ufo = _pool.GetFreeElement();
        ufo.transform.position = rPosition;
        GameData._UFOCounter++;
    }
    
    private IEnumerator SpawnUFOCoroutine(float rate)
    {
        
        while (true)
        {
            if (GameData._UFOCounter ==0)
            {
                CreateUFO();
                Debug.Log("spawn");
            }
            yield return new WaitForSeconds(rate);
        }
        
    }
}
