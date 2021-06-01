using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Destroy class
public class Destroy : MonoBehaviour
{
    public GameObject Boss; // Gameobject Boss
    [SerializeField] private Animator Death; // Animator death

    // On trigger between a collider and trigger
    private void OnTriggerEnter(Collider collider)
    {
         if (collider.gameObject.tag == "Player") // if the colliding object has the tag 'Player' do the following
         {
            Death.SetTrigger("Death"); // Set animator to play death animation
            Invoke("KillBoss", 3); // Wait '3' second(s), before calling 'Destroy'
        }
    }

    // Destroy game object (boss)
    private void KillBoss()
    {
        Destroy(this.Boss); // Destroy 'boss' game object
    }
}