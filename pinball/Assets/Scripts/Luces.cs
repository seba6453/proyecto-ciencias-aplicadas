using UnityEngine;
using System.Collections;

public class Luces : MonoBehaviour
{
    private bool sw = false;
    private Renderer rend;
    public int puntaje = 100;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color",Color.grey);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Ball"))
        {   
            if(sw)
            {
                rend.material.SetColor("_Color",Color.grey);
                sw = false;
            }
            else
            {
                rend.material.SetColor("_Color",Color.yellow);
                sw = true;
            }
        }
    }

    public bool get_sw()
    {
        return sw;
    }

    public int get_puntaje()
    {
        return puntaje;
    }

    public void reset()
    {
        rend.material.SetColor("_Color",Color.grey);
        sw = false;
    }
}
