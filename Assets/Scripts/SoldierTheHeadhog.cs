using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoldierTheHeadhog : MonoBehaviour
{
    [Range(0, 1)]
    public AnimationCurve curve;
    public float Movespeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
       rot.z += 5;
        transform.eulerAngles = rot;
        transform.position += Vector3.right * Movespeed * Time.deltaTime;
    }

}

