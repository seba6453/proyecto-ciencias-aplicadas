using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpeed : MonoBehaviour
{
    private Rigidbody rb;
    public float newGravity = 0.1f;  //gravity on the moon.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, -1.0f, 0) * rb.mass * newGravity);
    }

}
