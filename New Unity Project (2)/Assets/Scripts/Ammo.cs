using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = transform.forward * speed;
        //Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        //Destroy(gameObject);
    }
}
