using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MoveWithoutInputY class
public class MoveWithoutInputY : MonoBehaviour
{
    public float delta = 1.5f;  // Float delta, amount to move left and right from the starting object transform
    public float speed = 2.0f; // Float speed
    private Vector3 startPos; // Vector3 start position 

    // On program start
    void Start()
    {
        startPos = transform.position; // Start position set to object transform position
    }

    // Update per passing frame
    void Update()
    {
        Vector3 vDirection = startPos; // Set vDirection to object start position
        vDirection.y += delta * Mathf.Sin(Time.time * speed); // Add and equal vDirection in the 'Y' axis, per passing frame
        transform.position = vDirection; // Set object transform to vDirection, per passing frame
    }
}