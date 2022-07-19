using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    private  Camera _camera;
    void Start()
    {
        _camera = Camera.main;
    }

    
    void Update()
    {
        if (PauseMenu.gameIsPaused==false)
        {
            Vector2 screenMousePosition = Input.mousePosition;
            var difference = _camera.ScreenToWorldPoint(screenMousePosition) - transform.position;
            var rotateZ = Math.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            var target = Quaternion.Euler(0f,0f,((float) (rotateZ) - 100));
            transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime * 2);
        }
        
      //  transform.Rotate(0f,0f, ((float)rotateZ-100) * 0.005f);
        
     
    }
}
