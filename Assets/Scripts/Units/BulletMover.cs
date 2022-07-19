using System;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    
    private void Update()
    {
        this.transform.Translate(0,_speed ,0);
    }

    
    private void OnEnable()
    {
        _speed = (float) 0.1;
       
    }

    private void OnDisable()
    {
        _speed = 0;
    }
}
