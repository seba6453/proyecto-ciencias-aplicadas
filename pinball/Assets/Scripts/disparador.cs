using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{

    public GameObject disparador1;
    public GameObject pared;
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
            disparador1.SetActive(true);
        }
    }

    public void resetPared()
    {
        pared.SetActive(false);
        disparador1.SetActive(false);
    }
}
