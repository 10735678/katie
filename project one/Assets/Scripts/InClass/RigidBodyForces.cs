
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class RigidBodyForces : MonoBehaviour
{
    public Rigidbody rigidBodyObject;
    public float force = 1000;
    private Vector3 forceVector;


    private void Start()
    {
        rigidBodyObject = GetComponent<Rigidbody>();

    }
    private void OnCollisionEnter(Collision other)
    {
        forceVector.y = force;
        rigidBodyObject.AddForce(forceVector);
    }
}
