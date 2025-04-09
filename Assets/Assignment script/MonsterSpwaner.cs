using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpwaner : MonoBehaviour
{
    //veriables to refrence the monster spawner game object
    public GameObject MonsterSpawner;
    public GameObject Monster;//the object that is being spawned by the game object
    public GameObject newMonster;

    public float spawnTime = 3f;//The veriable that handels the spawn time of each monster

    Coroutine SpawnerCoroutine;// setting a coroutine to spawn monsters
    IEnumerator Spawn;


    // Start is called before the first frame update
    void Start()
    {
        SpawnerCoroutine = StartCoroutine(MonsterRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MonsterRoutine()
    {
        while (true)
        {
            SpawnMonstersInfront();
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void SpawnMonstersInfront()

    {
        Vector2 posToSpawn = new Vector3(Random.Range(-9.5f, 9.5f), 6.2f);
        newMonster.transform.parent = MonsterSpawner.transform;
    }
}
