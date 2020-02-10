
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class characterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float gravity = -5f;
    public float speed = 10f;
    public float speedBoost = 30f;
    public float jumpforce = 30f;
    public float growth = 5f;
    void Start()
    {

 
    }
    
    
    void Update()
    {
        positionDirection.x = Input.GetAxis("Vertical")* speed;
        positionDirection.z = Input.GetAxis("Horizontal")* speed;
        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpforce;
        }

        positionDirection.y -= gravity;

        controller.Move(positionDirection * Time.deltaTime);
        
        //speed boost
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }

        //Game over objects
        if (other.gameObject.CompareTag("Death")) 
        {
            Object.Destroy(gameObject);
            print("Game Over");
        }
        if (other.gameObject.CompareTag("Boost")) 
        {
            positionDirection.x = Input.GetAxis("Vertical")* speedBoost;
            positionDirection.z = Input.GetAxis("Horizontal")* speedBoost;
        }
        
    }
}


