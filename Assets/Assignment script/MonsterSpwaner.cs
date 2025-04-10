using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpwaner : MonoBehaviour
{
    //veriables to refrence the monster spawner game object
    public GameObject MonsterSpawner;
    public GameObject Monster;//the object that is being spawned by the game object
    //public GameObject newMonster;

    public float spawnTime = 2f;//The veriable that handels the spawn time of each monster

    Coroutine SpawnerCoroutine;// setting a coroutine to spawn monsters
    //IEnumerator Spawn;


    // Start is called before the first frame update
    void Start()
    {
       SpawnerCoroutine = StartCoroutine(MonsterRoutine());
    }

    IEnumerator MonsterRoutine()
    {
        while (true)
        {
            SpawnMonsters();
            yield return new WaitForSeconds(spawnTime);
            Debug.Log("Spawnmonsters");
        }
    }

    public void SpawnMonsters()

    {
        Vector2 posToSpawn = transform.position;
        Vector3 rotationToSpawn = new Vector3(0, 180, 0);
        GameObject newEnemy = Instantiate(Monster, posToSpawn, Quaternion.Euler(rotationToSpawn));
        newEnemy.transform.parent = MonsterSpawner.transform;
        Debug.Log("Spawnenemy");
    }
}
