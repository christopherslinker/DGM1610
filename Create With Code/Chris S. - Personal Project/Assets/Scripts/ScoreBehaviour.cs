using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ScoreBehaviour : MonoBehaviour
{

    private int score;

    public TextMeshProUGUI scoreText;
    

    void Start()
    {
        score = 0;
        UpdateScore(0);
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
