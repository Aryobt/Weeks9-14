using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
//In this script I have the monsters move speed and direction of movement
public class MonsterMove : MonoBehaviour
{
    bool isDead = false;//calling a bool that is declared to be false so when it is true it would get true

    public SpriteRenderer sr;//added an sprite renderer

    public float MonsterSpeed = 0.05f;// a public veriable to call the speed of the monster 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;// updating the position on the monster in every frame

        pos.x -= MonsterSpeed;// the monsters X position decreases in every frame
        
        transform.position = pos;// the position transformation is equal to pos

        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(sr.bounds.Contains(mousePos))
            {
                isDead = true;
                Destroy(gameObject, 0.05f);
            }

            
        }
    }

 
        
}
