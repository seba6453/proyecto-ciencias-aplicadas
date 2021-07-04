using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador : MonoBehaviour
{

    public float score = 0;
    public float puntaje_bumper;
    
    public float puntaje_DropT;

    public float puntaje_plunger;

    public Control_luces[] luces;

    //agregar los otros objetos que suman puntos (hablarlo en reunion)

    void Update()
    {
        for (int i = 0;i < luces.Length;i++)
        {
            score += luces[i].get_puntaje();
        }
        
    }
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
        else if(col.gameObject.CompareTag("drop"))
        {
            score += puntaje_DropT;
        }
    }

    public float get_puntaje()
    {
        return score;
    }
}
