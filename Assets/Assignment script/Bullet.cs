using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawn : MonoBehaviour
{
  //  [Range(0f, 1f)]
  //  public float t;
   // public AnimationCurve bullet;

   // public Vector2 start;
   // public Vector2 end;

    public Vector3 mousePos;

  
     
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))// so if the mouse button is pressed change the position of the bullet to where the mouse is
        {
           mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           mousePos.z = 0;
            transform.position = mousePos;

            //transform.position = Vector2.Lerp(start, end, bullet.Evaluate(t));
        }

       
    }
}
