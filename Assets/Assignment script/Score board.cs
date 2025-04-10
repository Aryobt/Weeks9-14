using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//usign Ui component in unity
using TMPro;//using Textmesh pro in unity
using Unity.VisualScripting;//using text mesh pro component in unity


public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreText;//a public text called score text
    private int score;//A private intigure that is called score

    private MonsterMove monsterMove;//calling a private veriable

    // Start is called before the first frame update
    void Start()
    {
        score = 0;//The score is set to start at 0
        monsterMove = GetComponent<MonsterMove>();//trying to get component from the MonsterMove script
        UpdateScore();//the score is set to be updated
    }

    public void AddScore(int points)//A public void that would happen once to add score using the intiger 
    {
        score += points;//
        UpdateScore();//calling a function
    }

    public void UpdateScore()//a void to update the score in each frame
    {
        scoreText.text = "Enemies dead: " + score.ToString();//updating the points and calling it Enemies dead and making them into a string
    }

     void Update()
    {
     //if(monsterMove ==true)
        //{
         //   AddScore(1);
       // }
    }

}
