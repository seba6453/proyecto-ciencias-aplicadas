using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDropT : MonoBehaviour
{
    Collider col1;
    Rigidbody rb1;
    Collider col2;
    Rigidbody rb2;
    Collider col3;
    Rigidbody rb3; 
    public static int cantDT = 0;
    public GameObject DT1;
    public GameObject DT2;
    public GameObject DT3; 
    
    void Start(){
        col1 = GetCollider(DT1); 
        rb1 = GetRigidbody(DT1); 
        col2 = GetCollider(DT2); 
        rb2 = GetRigidbody(DT2);
        col3 = GetCollider(DT3); 
        rb3 = GetRigidbody(DT3);
    }

    public Collider GetCollider(GameObject gameObject){
        Collider col = gameObject.GetComponent<Collider>(); //Se obtiene el Collider de 1 DropTarget
        return col;
    }

    public Rigidbody GetRigidbody(GameObject gameObject){
        Rigidbody rb = gameObject.GetComponent<Rigidbody>(); //Se obtiene el Rigidbody de 1 DropTarget
        cantDT += 1;
        Debug.Log(cantDT);
        return rb;
    }

    void Update()
    {
        if(cantDT == 0){
            subir(col1,rb1);
            subir(col2,rb2);
            subir(col3,rb3);   
        }
    }

    void subir(Collider col,Rigidbody rb){
        rb.AddForce(Vector3.up * 100f, ForceMode.Impulse);  //Hace que suban con mayor impulso
        cantDT += 1;
        Debug.Log(cantDT);
        col.enabled = true;
    }
}
