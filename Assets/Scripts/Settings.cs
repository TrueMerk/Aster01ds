using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private MouseRotator _mouseRotator;
    [SerializeField] private Text _text;
    private bool _scheme = true;
    
    public void ChangeSettings()
    {
        if (_scheme == true)
        {
            _input.shoot = KeyCode.Mouse0;
            _input.moveForward = KeyCode.Mouse1;
            _input.right = KeyCode.None;
            _input.left = KeyCode.None;
            _mouseRotator.enabled = true;
            _scheme = false;
            _text.text = "Мышь";
        }
        else
        {
            _input.shoot = KeyCode.Space;
            _input.moveForward = KeyCode.W;
            _input.right = KeyCode.A;
            _input.left = KeyCode.D;
            _mouseRotator.enabled = false;
            _scheme = true;
            _text.text = "Клавиатура";
        }
    }
}
