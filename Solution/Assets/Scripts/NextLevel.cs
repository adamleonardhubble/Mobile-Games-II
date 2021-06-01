using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// NextLevel class
public class NextLevel : MonoBehaviour {

    private int loadScene; // Integer load scene

	// On program start
	void Start ()
    {
        loadScene = SceneManager.GetActiveScene().buildIndex + 1; // Load scene, get next scene in build index (+1)
	}

    // On collision with a trigger
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(loadScene); // Load scene from trigger collision
    }
}
