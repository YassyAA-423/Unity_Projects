using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ball : MonoBehaviour
{
//This 
    public float speed;
    private Rigidbody rb;
    private void Start()
    {
        //This represents the player's body
        rb = GetComponent<Rigidbody>();
    }

    
    private void FixedUpdate()
    {
        //This will help the player move left or right.
        float moveHorizontal = Input.GetAxis("Horizontal");


        //This will help the player move up or down.
        float moveVertical = Input.GetAxis("Vertical");

        //This will be the Player speed
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}
