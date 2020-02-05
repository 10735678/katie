using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    // Unity Tutorial "CharacterControl"
    void Start()
    {
        Debug.Log("Moving Horizontally");
        Debug.Log("Jumping");
        Debug.Log("Moving Vertically");
    }

    
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
                transform.position += new Vector3(1, 0, 0);
            else
                transform.position += new Vector3(-1, 0, 0);

        }
        if (Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetAxis("Vertical") > 0)
                transform.position += new Vector3(0, 0, 1);
            else
                transform.position += new Vector3(0, 0, -1);

        }
        if (Input.GetAxis("jump") != 0)
        {
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
        }
        
    }
}
