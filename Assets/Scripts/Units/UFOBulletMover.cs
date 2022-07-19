
using System;
using UnityEngine;

public class UFOBulletMover : MonoBehaviour
{
    [SerializeField] private UFOShooter _player;
    [SerializeField] private GameObject _bullet;
    
    private void Update()
    {
      //  var t = GetComponentInParent<UFOShooter>();
       // var m = t._player.position;
       // transform.position = Vector2.MoveTowards(transform.position, m, (float) 0.009);
       this.transform.Translate(0,(float)0.1 ,0);
    }
}
