using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    //Update() call for every single frame when the game is running
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }



//FixedUpdate is called at Time Interval and mostly deals with physics

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.paddleSpeed);
        }
    }

}
