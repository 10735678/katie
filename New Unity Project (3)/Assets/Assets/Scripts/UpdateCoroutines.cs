using System;
using System.Collections;
using UnityEngine;

public class UpdateCoroutines : MonoBehaviour
{
    private WaitForFixedUpdate waitObj;
    public bool canRun = true;
    
    void Start()
    {
        waitObj = new WaitForFixedUpdate();
        StartCoroutine(OnStartCoroutine());
    }

    public IEnumerator OnStartCoroutine()
    {
        while (canRun)
        {
            yield return waitObj;
        }
    }
}
