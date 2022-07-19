using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField]private float _maxSpeed = 2;
    [SerializeField] private PlayerInput _input;
    [SerializeField] private BulletPool _bullet;
    [SerializeField] private float _shootRate;
    [SerializeField] private Transform _shotDir;
     private float _reload;
    private float _speed = 0;
    
    private void Update()
    {
        if (PauseMenu.gameIsPaused)
        {
            _speed = 0;
        }
        else
        {
            if (Input.GetKeyDown(_input.shoot))
            {
                if (_reload == 0)
                {
                    _bullet.CreateBullet(_shotDir);
                    _reload = _shootRate;
                }

            }
            
            if (_reload > 0)
            {
                _reload -= Time.deltaTime;
            }

            if (_reload < 0)
            {
                _reload = 0;
            }
            if (Input.GetKey(_input.moveForward))
            {
               Move();
            }
            else
            {
                InertStop();
            }
        }

        if(Input.GetKey(_input.left))
            Rotate(-1);
        
        if(Input.GetKey(_input.right))
            Rotate(1);
    }

    private void Rotate(float direction)
        {
            if (direction != 0)
                this.transform.Rotate(0,0,direction);
        }

    private void Move()
    {
        if (_speed < _maxSpeed)
        {
            _speed = (float) (_speed + 0.05);
        }

        transform.Translate(0, (float) 0.02 * _speed, 0);
    }

    private void InertStop()
    {
        if (!(_speed > 0)) return;
        _speed = (float) (_speed - 0.01);
        transform.Translate(0, (float) 0.02 * _speed, 0);
    }
}
