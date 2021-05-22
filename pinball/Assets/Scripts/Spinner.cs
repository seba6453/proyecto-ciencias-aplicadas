using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col){
        foreach(ContactPoint contact in col.contacts){
            transform.Rotate(Vector3.right*force*Time.deltaTime);
        }
    }
}
