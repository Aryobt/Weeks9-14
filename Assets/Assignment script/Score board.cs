using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoreboard : MonoBehaviour
{
    public Text scoreText;//a public text called score text
    private int score;//A private intigure that is called score

    // Start is called before the first frame update
    void Start()
    {
        score = 0;//The score is set to start at 0
        UpdateScore();//the score is set to be updated
    }

    public void AddScore(int points)//A public void that would happen once to add score using the intiger 
    {
        score += points;//
        UpdateScore();//
    }

    void UpdateScore()//a void to update the score in each frame
    {
        scoreText.text = "Score: " + score.ToString();//
    }

}
