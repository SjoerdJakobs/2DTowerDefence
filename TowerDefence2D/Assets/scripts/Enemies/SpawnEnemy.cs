using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {


    //GameObjects
    [SerializeField]
    private GameObject[] enemyToSpawn;
    private GameObject enemySpawnLoc;
    //GameObjects

    //Vector2
    private Vector2 enemySpawnVec;
    //Vector2

	void Start () 
    {
        enemySpawnLoc = GameObject.Find("EnemySpawner");
        enemySpawnVec = new Vector2(enemySpawnLoc.transform.position.x, enemySpawnLoc.transform.position.y);

        InvokeRepeating("SpawnEnemies", 0f, 1.5f);
	}
	
	void Update () 
    {
        
	}

    void ForEachEnemy()
    {
        foreach (GameObject enemy in enemyToSpawn)
        {
            // Do Something!
        }
    }


    void SpawnEnemies()
    {
        Instantiate(enemyToSpawn[Random.Range(0,enemyToSpawn.Length)],enemySpawnVec,Quaternion.identity);
    }
}
