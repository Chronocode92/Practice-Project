using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    // public 
    public float forceStrength; // how fast we move
    public Transform target; // the thing you want to chase

    // private
    private Rigidbody2D ourRigidbody; // the rigidbody attached to this object for movement


    // Awake is called when the script first loads
    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move in the direction of our target

        // Get the direction (as in enemy patrol) 
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;
        direction = direction.normalized;

        // move in the correct direction with the set force strength
        ourRigidbody.velocity=(direction * forceStrength);

    }
}
