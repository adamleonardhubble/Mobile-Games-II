using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MoveWithoutInputX class
public class MoveWithoutInputX : MonoBehaviour
{
    public Buttons buttonScript; // Include buttons class
    public float delta = 1.5f;  // Float delta, amount to move left and right from the starting object transform
    public float speed = 2.0f; // Float speed
    private Vector3 startPos; // Vector3 start position 
    public GameObject Player; // Gameobject player
    public Vector3 vDirection; // Vector3 vDirection
    public bool bContact = false; // Bool bContact
    public float YAxis; // Float y axis 

    // On program start
    void Start()
    {
        startPos = transform.position; // Start position set to object transform position
    }

    // On collision (colliders)
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == ("Player")) // If the colliding object has the tag 'Player', do the following
        {
            bContact = true; // Set bContact true
        }
        else // If the colliding object has another tag, do the following
        {
            bContact = false; // Set bContact false
        }
    }

    // Update per passing frame
    void Update()
    {
        vDirection = startPos; // Set vDirection to object start position
        vDirection.x += delta * Mathf.Sin(Time.time * speed); // Add and equal vDirection in the 'X' axis, per passing frame
        transform.position = vDirection; // Set object transform to vDirection, per passing frame
        float AxisX = vDirection.x; // Set AxisX equal to vDirection's 'X' axis value

        if (Player.transform.position.y > YAxis) // If the player jumps while on a moving pad, and the players 'Y' axis becomes larger than YAxis, do the following
        {
            bContact = false; // Set bContact false
        }

        if (bContact == true) // If bContact is true do the following
        {
            {
                Player.transform.position = new Vector3(AxisX, Player.transform.position.y, Player.transform.position.z); // Player transforms position to moving pad 'X' axis transform
            }
        }
        if (bContact == false) // If bContact is false do the following
        {
            {
                Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z); // Player transform position reverts back to player transform position
            }
        }
    }
}