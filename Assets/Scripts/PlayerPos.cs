using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    public Transform _playerTransform;

    private void Update()
    {
       var g =  GameObject.FindObjectOfType<PlayerMovement>();
        //Debug.Log(g.transform.position);
    }
}
