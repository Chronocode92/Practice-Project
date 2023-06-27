using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{
    // Public (editable in Unity)
    public float distanceForDecision; // How close the player must be to change behaviour
    public Transform target;

    // Private 
    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;

    // Awake is called when the object loads
    void Awake()
    {
        // Get the behaviours so we can turn them off and on
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();

        // Turn off the chase behaviour to start with
        chaseBehaviour.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // How far are we from our target?
        float distance = ((Vector2)transform.position - (Vector2)transform.position).magnitude;

        // IF we are closer to our target than our minimum distance...
        if (distance <= distanceForDecision)
        {
            // Disable patrol and enable chasing
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
        else
        {
            // Enable patrol and disable chasing
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
        }
    }
}
