using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //public variables
    public float forceStrength; // How fast we move
    public Vector2[] patrolPoints; // Patrol points we will move to
    public float stopDistance; // how close we get before moving before moving to next patrol point 

    // private variables
    private Rigidbody2D ourRigidbody; // The rigidbody on this object used to move
    private int currentPoint = 0; // Index of the current point we're moving towards


    // Awake is called when the script is loaded
    void Awake()
    {
        // Get the rigidbody attached to this object for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // How far are we from our target?
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        // IF we are closer to our target than our minimum distance...
        if (distance <= stopDistance)
            {
            // ...THEN, update to the next target
            currentPoint = currentPoint + 1;

            // If we've gone past the end of our list...
            // (if our current point index is equal or bigger than 
            // the length of our list)
            if (currentPoint >= patrolPoints.Length)
            {
                //...THEN, loop back to the start
                // by setting current index to 0
                currentPoint = 0;
            }
        }
        // Move in the direction of our target

        // Get the direction we should move in 
        // subtracting the current position from the target position
        Vector2 direction = patrolPoints[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;

        // move in the correct direction with the set force strength
        ourRigidbody.velocity=(direction * forceStrength);
    }
}
