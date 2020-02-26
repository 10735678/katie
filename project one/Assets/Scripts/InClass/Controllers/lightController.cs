using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]

public class lightController : MonoBehaviour
{
    public Light lightBrightness;
    
   
   void Start()
   {
        lightBrightness = GetComponent<Light>();
        lightBrightness.intensity = 0f;       
    }

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.L)) 
       {
           lightBrightness = GetComponent<Light>();
           lightBrightness.intensity = 1f;   
       }
       if (Input.GetKeyDown(KeyCode.O)) 
       {
           lightBrightness = GetComponent<Light>();
           lightBrightness.intensity = 0f;   
       }
   }
}
