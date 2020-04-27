using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private Image customImage;
    public int maxHealth = 100;
    public int currentHealth;
    public int cherry = 10;
    
    public HealthBar healthBar;
    
    
    void Start()
    {
        {
            customImage.enabled = false;
        }
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    void OnTriggerEnter (Collider other)
        {
            if (other.CompareTag("Player"))
            {
                TakeDamage(20);
            }

            if (other.CompareTag("Cherry")) 
            {
                {
                    AddHealth(10);
                }
                
            }
            
        }

    void AddHealth(int cherry)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += cherry;
            healthBar.SetHealth(currentHealth);
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currentHealth <= 0)
        {
            print("Out of Life");
            customImage.enabled = true;
        }
        else
        {
            print("Avoid the ducks. Shoot to kill them.");
        }

    }
    
    
}
