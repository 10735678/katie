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
}
