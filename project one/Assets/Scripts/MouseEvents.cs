
using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{

    public UnityEvent mouseDownEvent, mouseUpEvent, mouseOverEvent, mouseEnterEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }
    

}
