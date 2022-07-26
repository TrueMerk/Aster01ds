using UnityEngine;

public class AsteroidsStartRotation : MonoBehaviour
{
    void Start()
    {
        this.transform.Rotate(0,0,Random.Range(0,360) );
    }
    
}
