using UnityEngine;

public class BorderTeleport : MonoBehaviour
{
    
    [SerializeField] private float _xMin;
    [SerializeField] private float _xMax;

    [SerializeField] private float _yMin;
    [SerializeField] private float _yMax;
    
    private void Update()
    {
        var position = transform.position;

        if (position.x < _xMin)
            position.x = _xMax;

        if (position.y < _yMin)
            position.y = _yMax;

        if (position.x > _xMax)
            position.x = _xMin;

        if (position.y > _yMax)
            position.y = _yMin;
        transform.position = position;
    }
}
