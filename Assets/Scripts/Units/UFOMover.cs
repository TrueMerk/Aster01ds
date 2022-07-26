using DefaultNamespace;
using UnityEngine;

public class UFOMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (PauseMenu.gameIsPaused == false)
        {
            transform.Translate((float) (_speed*0.002),0 ,0);
        }
       
    }
    
}
