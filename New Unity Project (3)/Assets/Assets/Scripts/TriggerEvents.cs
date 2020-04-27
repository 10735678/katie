using UnityEngine;
using UnityEngine.Events;
public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    void OnTriggerEnter (Collider other)
    {
        //if (other.CompareTag("Pick Up"))
        triggerEnterEvent.Invoke();
    }
}
