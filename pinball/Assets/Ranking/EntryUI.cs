using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Name.boards{
    public class EntryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI entryName = null;
        [SerializeField] private TextMeshProUGUI entryScore = null;

        public void Initialise(EntryData entryData){
            entryName.text = entryData.entryName;
            entryScore.text = entryData.entryscore.ToString();
        }
    
    }
}