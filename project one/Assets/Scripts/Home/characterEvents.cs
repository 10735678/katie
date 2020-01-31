using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class characterEvents : MonoBehaviour
{
    public UnityEvent downEvent, upEvent, enterEvent;

    private void OnMouseDown()
    {
        downEvent.Invoke();
    }
    private void OnMouseUpAsButton()
        {
            upEvent.Invoke();
        }
    private void OnMouseDrag()
    {
        enterEvent.Invoke();
    }
    
}
