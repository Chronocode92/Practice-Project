using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //Unity editor variable
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    //ACTION: Fire a projectile
    public void FireProjectile()
    {
        // Clone the projectile
        // Declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        // Position the projectile on the player
        clonedProjectile.transform.position = transform.position; // OPTIONAL: Add an offset (use a public variable)

        // Fire it in a direction
        // declare a variable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        //Get the Rigidbody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;

        // play firing animation
        // declare a variable to hold the animation on our player
        Animator playerAnimator;
        // Get the animation already attached to our player so we can use it
        playerAnimator = GetComponent<Animator>();
        // use the animator component to trigger an animation change for attacking
        playerAnimator.SetTrigger("attack");

    }
}
