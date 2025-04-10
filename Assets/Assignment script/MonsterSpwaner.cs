using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.SocialPlatforms;

public class MonsterSpwaner : MonoBehaviour
{
    //veriables to refrence the monster spawner game object
    public GameObject MonsterSpawner;//calling a game object monsterspawner

    public GameObject Monster;//the object that is being spawned by the game object
    //public GameObject newMonster;

    public float spawnTime = 2f;//The veriable that handels the spawn time of each monster

    Coroutine SpawnerCoroutine;// setting a coroutine to spawn monsters
    //IEnumerator Spawn;


    // Start is called before the first frame update
    void Start()
    {
       SpawnerCoroutine = StartCoroutine(MonsterRoutine());//Begin a coroutine at the start of the code
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
    }
}
