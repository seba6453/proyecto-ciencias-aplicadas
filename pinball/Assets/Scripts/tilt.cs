using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    private Vector3 target1; //posicion 1
    private Vector3 target2; //posicion 2
    public Flippers R; //fliper derecho
    public Flippers L; //fliper izquierdo
    public float speed; //velocidad de movimiento
    public int veces; //cantidad de movimientos
    private int contador; //contador de movimientos
    private float dist; //distancia entre target1 y target2
    private bool confirmacion; //switch para funcionamiento del tilt
    private Vector3 position; //posicion inicial
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        confirmacion = true;
        contador = 0;
        target1 = transform.position + new Vector3(5,0);
        target2 = transform.position + new Vector3(-5,0);
        dist = Vector3.Distance(target1,target2);
    }

    // Update is called once per frame
    void Update()
    {
        if(contador > veces){ //desactiva el funcionamiento de los flipper
            confirmacion = false;
            R.setActive(false);
            L.setActive(false);
            positionInit(speed * Time.deltaTime);
        }
        if(Input.GetKey("left") && confirmacion){ //inicia el funcionamiento del tilt con el boton indicado
            contador++;
            Debug.Log(contador);
            if(Vector3.Distance(transform.position,target1) == dist){ //se mueve de derecha a izquierda dependiendo de la posicion del objeto
                moveA(speed * Time.deltaTime);
            }
            else{
                moveB(speed * Time.deltaTime);
            }
        }else{
            positionInit(speed * Time.deltaTime);
        }
        
    }
    private void moveA(float step) //mover el objeto del target 1 al target 2
    {
        //Realmente esto mueve el objeto al target 1
        transform.position = Vector3.MoveTowards(transform.position,target1,step);
    }

    private void moveB(float step) //mover el objeto del target 2 al target 1
    {
        //Realmente esto mueve el objeto al target 2
        transform.position = Vector3.MoveTowards(transform.position,target2,step);
    }

    private void positionInit(float step){ //mueve el objeto a la posicion inicial
        transform.position = Vector3.MoveTowards(transform.position,position,step);
    }

    public void reset(){ //resetea los valores y se activan los flippers
        contador = 0;
        confirmacion = true;
        L.setActive(true);
        R.setActive(true);
    }
}
