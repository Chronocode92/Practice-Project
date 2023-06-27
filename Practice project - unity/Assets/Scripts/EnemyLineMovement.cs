using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    //public variables
    //exposed for editing in the unity editor
    public float forceStrength; // how hard the script pushes the
                                // enemy aka how fast the enemy moves
    public Vector2 direction;   // What direction the enemy should move in

    // Private variables 
    // Not visible in editor
    // Used for tracking data while the game is running
    private Rigidbody2D ourRigidbody; // the container for rigidbody
                                        // attached to this object


    // Awake is called when the script is first loaded
    void Awake()
    {
        // Get and store the rigidbody we'll be using for movement
        ourRigidbody = GetComponent  <Rigidbody2D>();

        // Normalise our direction 
        // Normalise changes it to be length 1, so we can multiply
        // it by our speed / force later
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
