using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public float slingshotForce;

    public void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            contact.otherCollider.GetComponent<Rigidbody>().AddForce(-1 * contact.normal * slingshotForce, ForceMode.Impulse);

        }
    }
}
