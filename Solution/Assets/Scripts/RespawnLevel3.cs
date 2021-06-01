using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// RespawnLevel3 class
public class RespawnLevel3 : MonoBehaviour
{
    [SerializeField] private Transform Player; // Player transform
    [SerializeField] private Transform Projectile; // Projectile transform
    [SerializeField] private Transform respawnPlayerPoint; // Player respawn transform
    [SerializeField] private Transform respawnProjectilePoint; // Projectile respawn transform
    [SerializeField] private Animator Death; // Animator death

    // On collision between a collider and trigger
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == ("Player")) // If the colliding object has the tag 'Player', do the following
        {
            Death.SetTrigger("Death"); // Set animator to play death animation
            Player.transform.position = respawnPlayerPoint.transform.position; // Player transforms position to player respawn transform
        }
        if (collider.gameObject.tag == ("Projectile")) // If the colliding object has the tag 'Projectile', do the following
        {
            Projectile.transform.position = respawnProjectilePoint.transform.position; // Projectile transforms position to projectile respawn transform
        }
    }
}