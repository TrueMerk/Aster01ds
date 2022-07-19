using System;
using DefaultNamespace;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    
    
    [SerializeField] private Health _health;
    [SerializeField] private int _score = 100;
    
    public void Start()
    {
        _health.OnHealthLeftEvent += OnHealthLeft;
    }
    
     private void OnHealthLeft()
     {
         GameData.score+= _score;
         GameData._asteroidCounter--;
         
     }


    
}