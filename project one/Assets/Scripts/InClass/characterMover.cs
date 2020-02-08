
using UnityEngine;

public class characterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float gravity = -5f;
    public float speed = 10f;
    public float jumpforce = 30f;

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
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}


