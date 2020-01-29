using UnityEngine;
using UnityEngine.Events;
public class HomeTriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}