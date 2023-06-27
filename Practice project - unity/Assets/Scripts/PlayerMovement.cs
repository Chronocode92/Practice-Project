using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // speed setting, in meters/second
    public float speed = 10;
    // jump speed setting, in meters/second
    public float jumpSpeed = 10;
    // Reference variable so we can use the Rigidbody
    // Set it to null by default, which means we do NOT have a reference yet.
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;

    private Rigidbody2D physicsBody = null;
    // awake is called before Start
    private void Awake()
    {
        physicsBody = GetComponent < Rigidbody2D>();
    }

    public void MoveLeft()
    {
        // make a variable to hold our velocity and get the 
        // curent velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        // Set our velocity to move in the negative x (left) direction
        newVelocity.x = -speed;
        // Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        // make a variable to hold our velocity and get the 
        // curent velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;
        // Set our velocity to move in the positive x (right) direction
        newVelocity.x = +speed;
        // Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void jump()
    {
        // make a variable to hold our velocity and get the
        // current velocity from the physics component
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;
            // Set our velocity to move in the positive y (up) direction
            newVelocity.y = jumpSpeed;
            //Update our physics component's velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Get our Rigidbody that we'll need to find the physics information
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Find out from the rigidbody what our current horizontal and vertical speeds
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // Get the animator component that we will be using for setting our animation
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are 
        ourAnimator.SetFloat("SpeedH", currentSpeedH);
        ourAnimator.SetFloat("SpeedV", currentSpeedV);

   
    }
}
