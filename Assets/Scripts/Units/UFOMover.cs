using UnityEngine;

public class UFOMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate((float) (_speed*0.002),0 ,0);
    }
    
}
