using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Name.boards{
    public class Anotador_Ranking : MonoBehaviour
    {
        EntryData entryData = new EntryData();
        public control control;

        public void ReadName(string s){
            if(control.score.text != null){
                Debug.Log(control.score.text);
                float hola = control.GetComponent<Marcador>().score;   
                entryData.entryName = s;
                entryData.entryscore = hola;
            }    
        }
    
    }
}
