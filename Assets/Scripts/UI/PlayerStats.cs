using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private Text _speedText;
   [SerializeField] private Text _angText;
   [SerializeField] private Text _coordText;
   [SerializeField] private Text _coordText2;
   private float _ang;
    private float _coordX;
    private float _coordY;
    
    private void Update()
    {
        Stats();
        _angText.text = $"Angle: {_ang}";
        _coordText.text = $"Сoordinates: x= {_coordX}";
        _coordText2.text = $" y={_coordY}";
      
    }
    
    private void Stats()
    {
        _ang=(float) Math.Round(transform.localEulerAngles.z,1);
        _coordX = (float) Math.Round(transform.position.x,1);
        _coordY = (float) Math.Round(transform.position.y,1);
    }
    
}
