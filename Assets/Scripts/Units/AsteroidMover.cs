using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _speedCash;
    
    private void Start()
    {
        _speedCash = _speed;
    }

    private void Update()
    {
        if (PauseMenu.gameIsPaused)
        {
            _speed = 0;
        }
        else
        {
            _speed = _speedCash;
        }
        this.transform.Translate(0,(float) (_speed*0.002) ,0);
    }
}
