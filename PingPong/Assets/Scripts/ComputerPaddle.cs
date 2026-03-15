using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        //This will help the computer track the ball
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.paddleSpeed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.paddleSpeed);
            }
        }
        else //This will help make the game a little more fair by getting the computer to go back to the center when ever the ball goes away
        {
            if(this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.paddleSpeed);
;           }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.paddleSpeed);
            }

        }
    }
}
