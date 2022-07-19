using System;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] private Health _health;
    public  event Action GameOverEvent;
    
    private void Start()
    {
        _health.OnHealthLeftEvent += OnHealthLeft;
    }

    private void OnHealthLeft()
    {
        GameOverEvent?.Invoke();
        Button.ShowStatic();
    }

}
