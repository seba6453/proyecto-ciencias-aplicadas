using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour
{
    public Marcador marcador;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: " + marcador.get_puntaje();
        
    }
}
