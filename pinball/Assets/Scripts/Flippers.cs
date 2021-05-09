using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public float restPosition = 0f; //Posicion de reposo
    public float pressedPosition = 45f; //Cuanto se demora en llegar a su posicion inicial
    public float hitStrenght = 10000f; //Fuerza que ejerce
    public float flipperDamper = 150f; //Fuerza con que se devuelve el flipper
    HingeJoint hinge; 
    public string inputName; //Nombre de la funcion
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>(); //Obtener objeto de rotacion
        hinge.useSpring = true; //Inicializa con true
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring(); 
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        if(Input.GetAxis(inputName) == 1){ //Si se aprieta el boton seleccionado
            spring.targetPosition = pressedPosition; 
        }
        else{
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
