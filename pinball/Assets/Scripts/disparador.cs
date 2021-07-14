using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{

    public GameObject pared;
    public GameObject disparador1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Ball"))
        {
            pared.SetActive(true);
        }
    }
}
