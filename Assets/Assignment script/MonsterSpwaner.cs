using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
//using  UnityEditor.PlayerSettings;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using  UnityEngine.Events;

public class MonsterSpwaner : MonoBehaviour
{
    UnityEvent Monstergrowth = new UnityEvent();//calling a new unity event

    SpriteRenderer sr;//calling a sprite renderer as sr

    //veriables to refrence the monster spawner game object
    public GameObject MonsterSpawner;//calling a game object monsterspawner

    public GameObject Monster;//the object that is being spawned by the game object

    public GameObject BigMonster;//the game object that is growing 

    //public GameObject newMonster;

    public float spawnTime = 2f;//The veriable that handels the spawn time of each monster

    public Button startButton;//refrencing the start button

    public Button stopButton;//refrencing the stop button

   

   

    Coroutine SpawnerCoroutine;// setting a coroutine to spawn monsters
    
    //IEnumerator Spawn;


    // Start is called before the first frame update
    void Start()
    {
       SpawnerCoroutine = StartCoroutine(MonsterRoutine());//Begin a coroutine at the start of the code

        sr = GetComponent<SpriteRenderer>();//sr get the its components from the sprite renderer

        MonsterBig MonsterBigBoi = BigMonster.GetComponent<MonsterBig>();//getting the component from another script

        startButton.onClick.AddListener(StartSpawning);//a listener that when clicked begins spawning
        stopButton.onClick.AddListener(StopSpawning);//a listener that when clicked stops the coroutine spawing 

        Monstergrowth.AddListener(MonsterBigBoi.GrowMonster);//adding a listener that when clicked makes the monsters bigger based on the other script

        //Debug.Log("Spawnmonsters");

    }

    IEnumerator MonsterRoutine()
    {
        while (true)//while this is true it would spawn the monsters
        {
            SpawnMonsters();
            yield return new WaitForSeconds(spawnTime);
           // Debug.Log("Spawnmonsters");//used to help me see if the code is working or not
        }
    }

    public void SpawnMonsters()//calling a public void known as Spawn monsters

    {
        Vector2 posToSpawn = new Vector3(28,Random.Range(-4f,4f));//a vector 2 that has the spawning position the x position is set but the y position is selected at random

        Vector3 rotationToSpawn = new Vector3(0, 180, 0);//a vector 3 that rotates the spawned game objects by 180

        GameObject newEnemy = Instantiate(Monster, posToSpawn, Quaternion.Euler(rotationToSpawn));//rotate the eular angle of the spawned gamed object

        newEnemy.transform.parent = MonsterSpawner.transform;//newEnemy becomes a child of MonsterSpawner and if the MonsterSpawner moves, rotates, or scales, newEnemy would do the samething

        // Debug.Log("Spawnenemy");//used to help me see if the code is working or not

        Monstergrowth.Invoke();


    }

    public void StartSpawning()//a public void to play the coroutine
    {
        if (SpawnerCoroutine == null)//if spawner is null begin the coroutine
        {
            SpawnerCoroutine = StartCoroutine(MonsterRoutine());
        }
    }

    public void StopSpawning()//a public void to stop the coroutine
    {
        if(SpawnerCoroutine != null)//if spawneer is not null stop coroutine
        {
            StopCoroutine(SpawnerCoroutine);
            SpawnerCoroutine = null;
        }
    }
   
}
