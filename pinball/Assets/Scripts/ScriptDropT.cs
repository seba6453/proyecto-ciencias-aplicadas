using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDropT : MonoBehaviour
{
    Collider col;
    Rigidbody rb; 
    void Start(){
        col = GetComponent<Collider>(); //Se obtiene el Collider de 1 DropTarget
        rb = GetComponent<Rigidbody>(); //Se obtiene el Rigidbody de 1 DropTarget
    }

    void OnCollisionEnter(Collision collision) //collision ->DT ;collision.collider -> Pelota
    {
        if(collision.collider.gameObject.CompareTag("Player")){ //Si el objecto que toco el DT tiene tag "Player" entra
            col.enabled = false;                        // El collider del DT se desactiva y el DT se cae
            rb.AddForce(Vector3.down *100f, ForceMode.Impulse);  //Hace que caiga con mayor impulso
        }
    }

}
