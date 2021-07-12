using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsePlunger : MonoBehaviour
{
    Rigidbody rb;

    void OnCollisionEnter(Collision colision){
        Debug.Log(colision.gameObject.name);
        if(colision.gameObject.name == "Ball"){
            rb = colision.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward *200f);
        }
    }
}
