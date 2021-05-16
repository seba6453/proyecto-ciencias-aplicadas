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
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    
    void Start(){
        col1 = GetCollider(DT1); 
        rb1 = GetRigidbody(DT1);
        buscarPos(pos1,DT1); 
        col2 = GetCollider(DT2); 
        rb2 = GetRigidbody(DT2);
        buscarPos(pos2,DT2);
        col3 = GetCollider(DT3); 
        rb3 = GetRigidbody(DT3);
        buscarPos(pos3,DT3);
    }

    public Collider GetCollider(GameObject gameObject){
        Collider col = gameObject.GetComponent<Collider>(); //Se obtiene el Collider de 1 DropTarget
        return col;
    }

    public Rigidbody GetRigidbody(GameObject gameObject){
        Rigidbody rb = gameObject.GetComponent<Rigidbody>(); //Se obtiene el Rigidbody de 1 DropTarget
        cantDT += 1;
        return rb;
    }

    void buscarPos(Vector3 vector,GameObject gameObject){
        vector = gameObject.transform.position;
        GuardarPos(vector);
    }
    void Update()
    {
        if(cantDT == 0){
            StartCoroutine(wait());
            subir(col1,rb1,DT1);
            subir(col2,rb2,DT2);
            subir(col3,rb3,DT3);   
        }
    }
    void subir(Collider col,Rigidbody rb,GameObject gameObject){
        rb.AddForce(Vector3.up * 100f, ForceMode.Impulse);  //Hace que suban con mayor impulso
        cantDT += 1;
        Debug.Log(cantDT);
        StartCoroutine(esperar(col,gameObject));
    }

    IEnumerator esperar(Collider col,GameObject gameObject){
        yield return new WaitForSeconds(1f);
        col.enabled = true;
        gameObject.transform.position = CargarPos();
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(1f);
        Debug.Log("entro");
    }

    public static void GuardarPos(Vector3 Posicion){
        PlayerPrefs.SetFloat("x",Posicion.x);
        PlayerPrefs.SetFloat("y",Posicion.y);
        PlayerPrefs.SetFloat("z",Posicion.z);
    }

    public static Vector3 CargarPos(){
        Vector3 posicion;
        posicion.x = PlayerPrefs.GetFloat("x");
        posicion.y = PlayerPrefs.GetFloat("y");
        posicion.z = PlayerPrefs.GetFloat("z");
        return posicion;
    }

}
