using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.SetText(score.ToString());
    }
    
    public void IncreaseScore(int amountToIncrease) 
    {
        score = score + amountToIncrease;
        scoreText.SetText(score.ToString());
    }
}
