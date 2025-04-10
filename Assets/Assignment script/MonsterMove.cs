using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;
//In this script I have the monsters move speed and direction of movement
public class MonsterMove : MonoBehaviour
{
    Scoreboard scoreboard;

    public bool isDead = false;//calling a bool that is declared to be false so when it is true it would get true

    public SpriteRenderer sr;//added an sprite renderer

    public float MonsterSpeed = 0.05f;// a public veriable to call the speed of the monster 

    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GameObject.Find("Score").GetComponent<Scoreboard>();//search the Score code from the Score board script
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;// updating the position on the monster in every frame

        pos.x -= MonsterSpeed;// the monsters X position decreases in every frame
        
        transform.position = pos;// the position transformation is equal to pos

        if(Input.GetMouseButtonDown(0))//if the mouse button is pressed and the mouse is on the monster if the mouse is pressed turn the bool true and destroy the game object and add 1 to the score board
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(sr.bounds.Contains(mousePos))
            {
                scoreboard.AddScore(1);//add 1 to the score board
                isDead = true;
                Destroy(gameObject, 0.05f);
            }

            
        }
    }

 
        
}
