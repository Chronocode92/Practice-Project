using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // Built-in Unity function for handling collisions
    // this function will be called when another object bumps
    // into the one this script is attached to
    void OnCollisionEnter2D(Collision2D collisionData)

    {
        // Get the object we collided with 
        Collider2D objectWecollidedwith = collisionData.collider;

        // Get the PlayerHealth script attached to that object (if there is one)
        PlayerHealth Player = objectWecollidedwith.GetComponent<PlayerHealth>();

        // check if we actually found a player health script on the object we collided with
        // This if statement is true if the player variable is NOT null (aka empty)
        if (Player != null)
        {
            // This means there WAS a PlayerHealth script attached to the object we bumped into
            // which means this object is indeed the player

            //  Therefore perform our action 
            Player.Kill();
        }
    }
}