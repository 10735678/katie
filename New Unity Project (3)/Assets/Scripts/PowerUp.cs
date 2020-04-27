using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float size = 2f;
    public float time = 5f;
    public GameObject pickupAction;
    
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupAction, transform.position, transform.rotation);
        player.transform.localScale *= size;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        
        yield return new WaitForSeconds(time);    
        player.transform.localScale /= size;
        
        Destroy(gameObject);
    }
    
}