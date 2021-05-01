using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arquero : MonoBehaviour
{
    public Transform target1; //es 1 de los objetos al que quiero que se mueva
    public Transform target2; // segundo objeto al que quiero que se mueva
    public float speed; //velocidad a la que se debe mover
    private bool confi; // variable de confirmacion

    void Awake()
    {
        transform.position = target2.position; //posiciona el objeto en el target 2
    }
    void Start()
    {
        confi = true;
    }

    void Update()
    {
        //speed * Time.deltaTime es la multiplicacion de la velocidad con 
        //el tiempo por fotograma del unity para que funcione bien en cada pc

        float distancia1a2 = Vector3.Distance(target1.position,target2.position); // calcula la distancia entre cada target
        float distancia1Objeto = Vector3.Distance(target1.position,transform.position); //calcula la distancia entre el objeto y un target
        
        //el siguiente if decide si el objeto ira hacia la izquierda o derecha
        //confi = true =>izquierda ; confi = false => derecha
        if(distancia1Objeto == 0)
        {
            confi = false;
        }
        else if(distancia1a2 == distancia1Objeto)
        {
            confi = true;
        }

        //este if realiza el movimiento
        if(confi)
        {
            moveA(speed * Time.deltaTime);
        }
        else if(!confi)
        {
            moveB(speed * Time.deltaTime);
        }
        
        
    }

    private void moveA(float step) //mover el objeto del target 1 al target 2
    {
        //Realmente esto mueve el objeto al target 1
        transform.position = Vector3.MoveTowards(transform.position,target1.position,step);
    }

    private void moveB(float step) //mover el objeto del target 2 al target 1
    {
        //Realmente esto mueve el objeto al target 2
        transform.position = Vector3.MoveTowards(transform.position,target2.position,step);
    }
}