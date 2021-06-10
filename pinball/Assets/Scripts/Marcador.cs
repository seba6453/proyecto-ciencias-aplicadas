using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador : MonoBehaviour
{

    public float score = 0;
    public float puntaje_bumper;
    
    public float puntaje_DropT;

    public float puntaje_plunger;

    //agregar los otros objetos que suman puntos (hablarlo en reunion)

    void OnCollisionEnter(Collision col)
    {
        //Se compara con el nombre del objeto que tiene el collider, la otra forma es comparar por tag (hablarlo en reunion)
        if (col.gameObject.CompareTag("Bumper"))
        {
            score += puntaje_bumper;
        }
        else if (col.gameObject.CompareTag("Slingshot"))
        {
            score += puntaje_plunger;  // solo de prueba uwu
        }
    }
}
