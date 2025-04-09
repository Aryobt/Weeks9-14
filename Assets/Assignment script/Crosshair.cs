using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This code contais the crosshair's movement
public class Crosshair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint( Input.mousePosition );// Both the X and Y of the crosshair would be updated to the X and Y of the mouse

        transform.position = mouse;// make the position equal to the mouse position
    }
}
