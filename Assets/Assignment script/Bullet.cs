using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//This code contains the details for the bulletr prefab 
public class Bulletspawn : MonoBehaviour
{
  
   public float BulletSpeed;//calling a public veriable named BulletSpeed
   /// </summary>






    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()//Updating the position of the bullet in each frame
    {
        Vector3 pos = transform.position;
        pos.x += BulletSpeed * Time.deltaTime;

        transform.position = pos;
       
    }
}
