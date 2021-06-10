using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropT2 : MonoBehaviour
{
    Collider col1,col2,col3;
    Rigidbody rb1,rb2,rb3;
    public static int cantDT2 = 0;
    public GameObject DT1,DT2,DT3;
    
    void Start(){                                   //Se obtienen los Collider y Rigidbody de cada DT
        col1 = DT1.GetComponent<Collider>();        //Ademas se guarda su posicion inicial
        rb1 = DT1.GetComponent<Rigidbody>();        //Se definen los 3 DT
        /*GuardarPos(DT1.transform.position); 
        col2 = DT2.GetComponent<Collider>();
        rb2 = DT2.GetComponent<Rigidbody>();
        GuardarPos(DT2.transform.position);
        col3 = DT3.GetComponent<Collider>(); 
        rb3 = DT3.GetComponent<Rigidbody>();
        GuardarPos(DT3.transform.position);*/
        cantDT2 = 3;
        Debug.Log(cantDT2);
    }

    /*
    void Update()
    {
        if(cantDT2 == 0){ 
            subir(col1,rb1,DT1);                //Reinicia a los 3 DT
            subir(col2,rb2,DT2);
            subir(col3,rb3,DT3); 
        }
    }

    void subir(Collider col,Rigidbody rb,GameObject gameObject){
        //rb.AddForce(Vector3.up * 50f, ForceMode.Impulse);   //Hace que suban con mayor impulso
        cantDT2 += 1;                                        //quiere decir que el DT esta levantado
        Debug.Log(cantDT2);
        StartCoroutine(esperar(col,gameObject));         
    }

    IEnumerator esperar(Collider col,GameObject gameObject){
        yield return new WaitForSeconds(1f);                  //espera por 2 segundos
        gameObject.transform.position = CargarPos();         //se carga la posicion inicial
        col.enabled = true;                                 //se activa el collider del DT
    }

    public static void GuardarPos(Vector3 Posicion){        //Guarda la posicion de cada componente
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
    }*/
}