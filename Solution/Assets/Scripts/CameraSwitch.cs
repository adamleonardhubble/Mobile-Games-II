using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cameraswitch class
public class CameraSwitch : MonoBehaviour
{
    public GameObject Player; // Gameobject player
    public Camera Camera1; // Camera object camera one
    public Camera Camera2; // Camera object camera two
    public Camera Camera3; // Camera object camera three
    public bool bSwitch; // Bool bSwitch
    public bool bSwitchScreen; // Bool bSwitchScreen


    // On program awakening
    void Awake()
    {
        bSwitch = false; // Set bSwitch to false
        Camera1.enabled = true; // Enable camera one
        Camera2.enabled = false; // Disable camera two
    }

    // On collision between a collider and trigger
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == ("Switch")) // If the colliding object has the tag 'Switch', do the following
        {
            bSwitch = true; // Set bSwitch to true
            bSwitchScreen = false; // Set bSwitchScreen to false
        }
        if (collider.gameObject.tag == ("Switch2")) // If the colliding object has the tag 'Switch2', do the following
        {
            bSwitch = false; // Set bSwitch to false
            bSwitchScreen = false; // Set bSwitchScreen to false
        }
        if (collider.gameObject.tag == ("Switch3")) // If the colliding object has the tag 'Switch3', do the following
        {
            bSwitch = false; // Set bSwitch to false
            bSwitchScreen = true; // Set bSwitchScreen to true
        }
        if (collider.gameObject.tag == ("Barrier")) // If the colliding object has the tag 'Barrier', do the following
        {
            bSwitch = false; // Set bSwitch to false
            bSwitchScreen = false; // Set bSwitchScreen to false
        }
        if (collider.gameObject.tag == ("Enemy")) // If the colliding object has the tag 'Enemy', do the following
        {
            bSwitch = false; // Set bSwitch to false
            bSwitchScreen = false; // Set bSwitchScreen to false
        }
        if (collider.gameObject.tag == ("Projectile")) // If the colliding object has the tag 'Projectile', do the following
        {
            bSwitch = false; // Set bSwitch to false
            bSwitchScreen = false; // Set bSwitchScreen to false
        }
    }

    // Update per passing frame
    void Update()
    {
        if (bSwitchScreen == true) // bSwitch is true do the following
        {
            Camera1.enabled = false; // Disabled camera one
            Camera2.enabled = false; // Disable camera two
            Camera3.enabled = true; // Enable camera three
        }
        else
        {
             if (bSwitch == true) // If bSwitch is true do the following
             {
                 Camera1.enabled = false; // Disable camera one
                 Camera2.enabled = true; // Enable camera two
             }
             if (bSwitch == false) // If bSwitch is false do the following
             {
                 Camera1.enabled = true; // Enable camera one
                 Camera2.enabled = false; // Enable camera two
             }
        }
        
    }
}

// Previous implementation
/*public GameObject Player;
public Camera Camera1;
public Camera Camera2;

// Use this for initialization
void Awake()
{
    Camera1.enabled = true;
    Camera2.enabled = false;
}


// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown("a"))
    {
        Camera1.enabled = true;
        Camera2.enabled = false;
    }
    if (Input.GetKeyDown("s"))
    {
        Camera2.enabled = true;
        Camera1.enabled = false;
    }
}*/
