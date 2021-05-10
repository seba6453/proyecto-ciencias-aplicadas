using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDropT : MonoBehaviour
{
    Collider col;
    Rigidbody rb; 
    public static int cantDT = 0;
    
    void Start(){
        col = GetComponent<Collider>(); //Se obtiene el Collider de 1 DropTarget
        rb = GetComponent<Rigidbody>(); //Se obtiene el Rigidbody de 1 DropTarget
        cantDT += 1;
        Debug.Log(cantDT);
    }

    public void OnCollisionEnter(Collision collision) //collision ->DT ;collision.collider -> Pelota
    {
        if(collision.collider.gameObject.CompareTag("Player")){ //Si el objecto que toco el DT tiene tag "Player" entra
            col.enabled = false;                        // El collider del DT se desactiva y el DT se cae
            rb.AddForce(Vector3.down * 100f, ForceMode.Impulse);  //Hace que caiga con mayor impulso
            cantDT -= 1;
            Debug.Log(cantDT);
        }
    }

    void Update()
    {
        if(cantDT == 0){
            col.enabled = true;
            rb.AddForce(Vector3.up * 100f, ForceMode.Impulse);  //Hace que suban con mayor impulso
            cantDT += 1;
            Debug.Log(cantDT);    
           
        }
    }

}
