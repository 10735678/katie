using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCherry : MonoBehaviour
{
    public float multiplier = 1.2f;
    public GameObject pickupEffect;
    
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //PlayerStats stats = player.GetComponent<PlayerStats>();
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.health *= multiplier;

        Destroy(gameObject);
    }
}
