using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision2 : MonoBehaviour
{
    public Transform target;
    public float speed;
    //Collider col;
    //Rigidbody rb;
    void Start(){
        //col = GetComponent<Collider>();
        //rb = GetComponent<Rigidbody>();
    }
    /*public void OnCollisionEnter(Collision collision) //collision ->DT ;collision.collider -> Pelota
    {
        if(collision.collider.gameObject.CompareTag("Ball")){ //Si el objecto que toco el DT tiene tag "Ball" entra
            col.enabled = false;                        // El collider del DT se desactiva y el DT se cae
            //rb.AddForce(Vector3.down * 50f, ForceMode.Impulse);  //Hace que caiga con mayor impulso
            if (!col.enabled){
                DropT2.cantDT2 -=1;
                Debug.Log(DropT2.cantDT2);
            }
            
        }
    }*/

    void Update(){
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position,step);
    }
}
