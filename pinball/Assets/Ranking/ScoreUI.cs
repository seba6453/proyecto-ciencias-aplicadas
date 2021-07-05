using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowUI;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager.AddScore(new Score("Juan",10));
        scoreManager.AddScore(new Score("Pedro",80));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUI,transform).GetComponent<RowUI>();
            row.rank.text = (i+1).ToString();
            row.Name.text = scores[i].Name;
            row.score.text = scores[i].score.ToString();
        }
    }

}
