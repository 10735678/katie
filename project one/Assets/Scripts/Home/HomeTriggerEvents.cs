using UnityEngine;
using UnityEngine.Events;
public class HomeTriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEvent(Collider Other)
    {
        triggerEnterEvent.Invoke();
    }
}