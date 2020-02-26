using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class spriteController : MonoBehaviour
{
    public Color spriteColor = Color.blue;
    public Color offColor = Color.blue; 
    
    private SpriteRenderer spriteObj;
    
   
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
       
        
    }

    private void OnEnable()
    {
        spriteObj.color = spriteColor;
        
    }
    private void OnDisable()
    {
        spriteObj.color = offColor;
        
    }
    
}
