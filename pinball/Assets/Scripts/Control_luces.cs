using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_luces : MonoBehaviour
{
    public int puntaje = 0;
    public Luces[] luces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(confirmacion())
        {
            for (int i = 0; i < luces.Length; i++)
            {
                puntaje += luces[i].get_puntaje();
            }
            reset();
        }
    }

    public void reset()
    {
        for (int i = 0; i < luces.Length; i++)
        {
            luces[i].reset();
        }
    }

    bool confirmacion()
    {
        bool conf = true;
        for (int i = 0; i < luces.Length; i++)
        {
            if(!luces[i].get_sw())
            {
                conf = luces[i].get_sw();
            }
        }
        return conf;
    }

    public int get_puntaje()
    {
        if(confirmacion())
        {
            return puntaje;
        }
        return 0;
        
    }


}
