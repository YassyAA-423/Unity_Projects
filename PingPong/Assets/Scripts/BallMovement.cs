using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D ballRigidBody;

    public float ballSpeed;


    // Start is called before the first frame update
    private void Start()
    {
        ResetBall();
    }

    private void randomDirection()
    {
        bool isRight = Random.value >= 0.5;

        float xVelocity = -1f;

        if (isRight == true)
        {
            xVelocity = 1f;
        }

        float yVelocity = Random.Range(-1f, 1f);

        ballRigidBody.velocity = new Vector2(xVelocity * ballSpeed, yVelocity * ballSpeed);
    }

    public void ResetBall()
    {
        ballRigidBody.position = Vector3.zero;
        ballRigidBody.velocity = Vector3.zero;
        
        randomDirection();
    }
}
