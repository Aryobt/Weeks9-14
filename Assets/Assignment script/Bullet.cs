using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bulletspawn : MonoBehaviour
{
  
   public float BulletSpeed;






    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += BulletSpeed * Time.deltaTime;

        transform.position = pos;
       
    }
}
