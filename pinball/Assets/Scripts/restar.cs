using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restar : MonoBehaviour
{
    public GameObject pared;

    private string nombre;

    public tilt arcade;

    public Vector3 posicion_inicial;

    private Rigidbody rb;
    void Awake(){
        rb = GetComponent<Rigidbody>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        nombre = pared.gameObject.name;
        transform.position = posicion_inicial;
        rb.velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == nombre) 
        {
            Start();
            arcade.reset();
        }
    }
}
