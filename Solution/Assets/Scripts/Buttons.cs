using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Buttons class
public class Buttons : MonoBehaviour {

    [HideInInspector] // Hide in inspector 
    public bool jumpPressed = false; // Bool jumpPressed set to false
    [HideInInspector] // Hide in inspector 
    public bool leftPressed = false; // Bool leftPressed set to false
    [HideInInspector] // Hide in inspector 
    public bool rightPressed = false; // Bool rightPressed set to false

    // Wait begin
    public void WaitBegin() 
    {
        Invoke("Begin", 1); // Wait '1' second(s), before calling 'begin'
    }
    // Wait quit
    public void WaitQuit()
    {
        Invoke("Quit", 1); // Wait '1' second(s), before calling 'quit'
    }

    // Up pressed
    public void UpPressed()
    {
        jumpPressed = true; // jumpPressed set to true
	}
    // Left pressed
    public void LeftPressed()
    {
        leftPressed = true; // leftPressed set to true
    }
    // Right pressed
    public void RightPressed()
    {
        rightPressed = true; // rightPressed set to true
    }

    // Left released 
    public void LeftReleased()
    {
        leftPressed = false; // leftPressed set to false
    }
    // Right released
    public void RightReleased()
    {
        rightPressed = false; // rightPressed set to false
    }

    // Quit button pressed
    public void Quit()
    {
        Application.Quit(); // Quit application 
        Debug.Log("Quit"); // Output to debug log to show working
    }
    // Start button pressed
    public void Begin()
    {
        SceneManager.LoadScene("FirstLevel"); // Load first scene on button press
    }
}
