using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float gravityone = -5f;
    public float speedone = 20f;
    public float boost = 30f;
    public float force = 50f;
    public int jumpercount = 0;
    public int jumpercountmax = 2;
    
   
        void Update()
            {
                positionDirection.x = Input.GetAxis("Vertical")* speedone;
                positionDirection.z = Input.GetAxis("Horizontal")* speedone;
                //JUMP
                if (Input.GetButtonDown("Jump") && jumpercount < jumpercountmax)
                {
                    positionDirection.y = force;
                    jumpercount++;
                }
        
                if (controller.isGrounded)
                {
                    jumpercount = 0;
                }
        
                positionDirection.y -= gravityone;
        
                controller.Move(positionDirection * Time.deltaTime);
                
            }
    }
