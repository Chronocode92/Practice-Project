using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Reference variable so we can use the Rigidbody
    // Set it to null by default, which means we do NOT have a reference yet.
    private Rigidbody2D physicsBody = null;
    // awake is called before Start
    private void Awake()
    {
        physicsBody = GetComponent < Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
