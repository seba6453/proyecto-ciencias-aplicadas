using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;
   
    public Text jugador;
    
    public void IngresarRank(Text score)
    {

        scoreManager.AddScore(new Score(jugador,score));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUI,transform).GetComponent<RowUI>();
            row.rank.text = (i+1).ToString();
            row.Name = scores[i].Name;
            row.score.text = scores[i].score.ToString();
        }
        
    }

}
