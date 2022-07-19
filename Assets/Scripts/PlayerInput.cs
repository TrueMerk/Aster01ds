using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public MouseRotator MouseRotator;
    [NonSerialized]public KeyCode shoot;
    [NonSerialized]public KeyCode moveForward;

    [NonSerialized] public KeyCode right;

    [NonSerialized] public KeyCode left;
    // Start is called before the first frame update
    private void Start()
    {
        shoot = KeyCode.Space;
        moveForward = KeyCode.W;
        right = KeyCode.A;
        left = KeyCode.D;
        MouseRotator.enabled = false;
    }

    
}
