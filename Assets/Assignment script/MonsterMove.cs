using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
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

    }
}
