using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    Collider col;
    Rigidbody rb;
    void Start(){
        col = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision) //collision ->DT ;collision.collider -> Pelota
    {
        if(collision.collider.gameObject.CompareTag("Ball")){ //Si el objecto que toco el DT tiene tag "Ball" entra
            Destroy(collision.collider.gameObject);
            col.enabled = false;                        // El collider del DT se desactiva y el DT se cae
            rb.AddForce(Vector3.down * 200f, ForceMode.Impulse);  //Hace que caiga con mayor impulso
            ScriptDropT.cantDT -=1;
            Debug.Log(ScriptDropT.cantDT);
            
        }
    }
}
