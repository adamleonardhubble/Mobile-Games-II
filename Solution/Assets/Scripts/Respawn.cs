using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Respawn class
public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player; // Player transform
    [SerializeField] private Transform respawnPoint; // Player respawn transform
    [SerializeField] private Animator Death; // Animator death

    // On collision between a collider and trigger
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == ("Player")) // If the colliding object has the tag 'Player', do the following
        {
            Death.SetTrigger("Death"); // Set animator to play death animation
            Player.transform.position = respawnPoint.transform.position; // Player transforms position to player respawn transform
        }
    }
}
