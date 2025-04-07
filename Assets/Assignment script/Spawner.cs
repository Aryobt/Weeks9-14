using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;//calling a public game object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//if the mouse button is down it would spawn muptiple copies of that game object that is being called
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newBullet = Instantiate(prefab, mouse, Quaternion.identity);
           // Instantiate(prefab, mouse, Quaternion.identity);
           Destroy(newBullet, 2 );//Destroys the bullet clones after 2 seconds
        }
    }
}
