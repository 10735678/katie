using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public bool canRun = true;
    void Start()
    {
        if (a + b <= c)
        {
            print("that is true");
        }

        if (canRun) ;
        {
            print("We can run");
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
