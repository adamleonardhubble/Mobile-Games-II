using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MoveMultiLaterally class
public class MoveMultiLaterally : MonoBehaviour
{
    public Buttons buttonScript; // Include buttons class

    public float jumpSpeed = 0.1f; // Jump speed
    public float rightSpeed = 0.1f; // Right speed
    public float leftSpeed = 0.1f; // Left speed
    public bool isGrounded; // Is the object grounded
    public bool isMoving; // Is the object moving
    Rigidbody Cube; // Cube rigidbody object

    // Start of program runtime
    void Start()
    {
        Cube = GetComponent<Rigidbody>(); // Get cube object rigidbody
        Vector3 vVelocity = Cube.velocity; // Get cube object velocity
    }

    // On collision (colliders)
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false) // If the colliding object has tag "Ground" and isGrounded is false, do the following
        {
            isGrounded = true; // Set isGrounded to true
        }
    }

    // Update per passing frame
    void Update()
    {
        if (isGrounded == false) // If isGrounded is false do the following
        {
            buttonScript.jumpPressed = false; // jumpPressed is set to false (cannot jump again(mid-air))
        }

        Vector3 vDirection = Vector3.zero; // vDirection is equivalent to zero
        vDirection.x = Input.GetAxisRaw("Horizontal"); // vDirection 'X' axis is equivalent to the input horizontal axis 

        if (buttonScript.leftPressed) // If left is pressed do the following
        {
            vDirection.x--; // Decrement 'X' axis transform of object
        }
        if (buttonScript.rightPressed) // If right is pressed do the following
        {
            vDirection.x++; // Increment 'X' axis transform of object
        }

        if (vDirection != Vector3.zero) // If vDirection is not equal to zero (moving), do the following
        {
            transform.Translate(vDirection * rightSpeed * Time.deltaTime, Space.World); // Transform vDirection multiplied by the set speed, and time passed since last update within the world space
        }

        if (isGrounded == true) // If isGrounded is true do the following
        {
            if (Input.GetKeyDown(KeyCode.Space) || buttonScript.jumpPressed == true) // If the space key is pressed, do the following
            {
                Cube.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse); // Apply impulse in 'Y' dimension of cube object relative to the jumpspeed
                isGrounded = false; // Set isGrounded to false
            }
        }
    }
}

// Alternative movement input, used to apply 
/* Cube = GetComponent<Rigidbody>();
 Vector3 vVelocity = Cube.velocity;

 if (vVelocity.x < 10)
 {
     if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetMouseButton(0) && isGrounded)
     {
         Cube.AddForce(new Vector3(1, 0, 0) * leftSpeed, ForceMode.Impulse);
         isGrounded = false;

     }
 }

 if (vVelocity.x > -10)
 {
     if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetMouseButton(0) && isGrounded)
     {
         Cube.AddForce(new Vector3(-1, 0, 0) * leftSpeed, ForceMode.Impulse);
         isGrounded = false;
     }
 }
 */
