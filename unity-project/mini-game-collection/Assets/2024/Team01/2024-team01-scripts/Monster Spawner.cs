using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    //This selects what Pefab we are using
    [SerializeField]
    private GameObject Monster;
    //This is the timer on how often a monster spawns
    public float MonsterIntervals = 3.5f;


    void Start()
    {
        //This code likes the timer and prefab to the code below
        StartCoroutine(spawnEnemy(MonsterIntervals, Monster));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to spawn monsters
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);         //X value of where they can spawn  Y Value
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-50f, 50), Random.Range(1f, 1.5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

}
