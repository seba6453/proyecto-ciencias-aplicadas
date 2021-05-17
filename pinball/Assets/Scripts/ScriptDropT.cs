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
        col1 = DT1.GetComponent<Collider>();
        rb1 = DT1.GetComponent<Rigidbody>();
        buscarPos(pos1,DT1); 
        col2 = DT2.GetComponent<Collider>();
        rb2 = DT2.GetComponent<Rigidbody>();
        buscarPos(pos2,DT2);
        col3 = DT3.GetComponent<Collider>(); 
        rb3 = DT3.GetComponent<Rigidbody>();
        buscarPos(pos3,DT3);
        cantDT = 3;
    }

    void buscarPos(Vector3 vector,GameObject gameObject){
        vector = gameObject.transform.position;
        GuardarPos(vector);
    }
    void Update()
    {
        if(cantDT == 0){ 
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
        yield return new WaitForSeconds(0.5f);
        col.enabled = true;
        gameObject.transform.position = CargarPos();
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
