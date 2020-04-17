
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float gravity = -5f;
    public float speed = 10f;
    public float speedBoost = 30f;
    public float jumpforce = 50f;
    public float growth = 5f;
    public float counter = 1f;
    private int jumpCount = 0;
    public int jumpCountMax = 2;
    void Start()
    {

 
    }
    
    
    void Update()
    {
        positionDirection.x = Input.GetAxis("Vertical")* speed;
       
        //JUMP
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpforce;
            jumpCount++;
        }

        if (controller.isGrounded)
        {
            jumpCount = 0;
        }

        positionDirection.y -= gravity;

        controller.Move(positionDirection * Time.deltaTime);
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            counter++;
            speed = speed + 5;
            print(counter);
        }
        
        //Game over objects
        if (other.gameObject.CompareTag("lower")) 
        {
            
            //Object.Destroy(gameObject);
            //print("Game Over");
        }
        if (other.gameObject.CompareTag("Boost")) 
        {
            positionDirection.x = Input.GetAxis("Vertical")* speedBoost;
          
        }
        
    }
}

