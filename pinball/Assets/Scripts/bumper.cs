using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    public float bumperForce;

    public void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            contact.otherCollider.GetComponent<Rigidbody>().AddForce(-1 * contact.normal * bumperForce, ForceMode.Impulse);

        }
    }


}
