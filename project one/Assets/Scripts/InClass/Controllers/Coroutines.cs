using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public string message = "Times up!";
    public IntData numberData;
    private WaitForSeconds waitObj;
    public UnityEvent startEvent, repeatEvent, endEvent;
    
    IEnumerator Start()
    {
        startEvent.Invoke();
        while (counter > 0)
        {
            numberData.value = counter;
            yield return new WaitForSeconds(seconds);
            repeatEvent.Invoke();
            counter--;
            
        }
        yield return new WaitForSeconds(seconds);
        endEvent.Invoke();
        
    }
}
