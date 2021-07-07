using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class Score
{
    public Text Name;
    public Text score;

    public Score(Text name,Text score){
        this.Name = name;
        this.score = score;
    }
}
