using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ammo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(ammo, transform.position, transform.rotation);
    }
}
