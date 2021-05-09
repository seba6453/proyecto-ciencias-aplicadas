using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        Debug.Log("Punto");
    }
}
