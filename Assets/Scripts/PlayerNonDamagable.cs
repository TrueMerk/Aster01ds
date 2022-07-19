using System.Diagnostics.Contracts;
using DefaultNamespace;
using UnityEngine;

public class PlayerNonDamagable : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Collider2D _collider2D;
    [SerializeField] private SpriteRenderer _renderer;
    private float _timeTp;
   

    private void Start()
    {
        _health.enabled = false;
        _collider2D.enabled = false;
        
    }

    private void Update()
    {
         if (PauseMenu.gameIsPaused == false)
        {
            if (_timeTp<3f) 
            {
                _timeTp += Time.deltaTime;
                _renderer.enabled = false;
            }
            else
            {
                _health.enabled = true;
                _collider2D.enabled = true;
                _renderer.enabled = true;
            }
        }
       
    }
}
