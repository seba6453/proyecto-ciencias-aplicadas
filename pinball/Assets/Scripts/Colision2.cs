using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision2 : MonoBehaviour
{
    public Transform target,target2;
    public float speed;
    Collider col;
    static int cantDT2 = 0;
    bool couroutineStarted = false;
    
    void Start(){
        col = GetComponent<Collider>();
        cantDT2 +=1;
    }
    public void OnCollisionEnter(Collision collision) //collision ->DT ;collision.collider -> Pelota
    {
        if(collision.collider.gameObject.CompareTag("Ball")){ //Si el objecto que toco el DT tiene tag "Ball" entra
            col.enabled = false;                        // El collider del DT se desactiva y el DT se cae
            float step = speed * Time.deltaTime*25;
            transform.position = Vector3.MoveTowards(transform.position, target.position,step);
            cantDT2 -=1;
        }
    }

   void Update()
    {
        if(cantDT2 == 0){
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target2.position,step);
            if(!couroutineStarted){
                StartCoroutine(UsingYield(2));
            }
        }        
    }
 
   IEnumerator UsingYield(int seconds)
   {
        couroutineStarted = true;
        yield return new WaitForSeconds(seconds);
        col.enabled = true;
        cantDT2 += 1;
        couroutineStarted = false;
   } 
}
