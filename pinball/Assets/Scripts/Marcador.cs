using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcador : MonoBehaviour
{

    public float score;
    public float drops;
    //agregar los otros objetos que suman puntos (hablarlo en reunion)

    void OnCollisionEnter(Collision col)
    {
        //Se compara con el nombre del objeto que tiene el collider, la otra forma es comparar por tag (hablarlo en reunion)
        if (col.gameObject.name == "group_0_16768282")
        {
            score += drops;
        }
        if (col.gameObject.name == "group_0_3888547")
        {
            score += drops;  // solo de prueba uwu
        }


    }
}
