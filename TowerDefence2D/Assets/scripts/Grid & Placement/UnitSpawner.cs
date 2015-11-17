using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnitSpawner : MonoBehaviour {

    //Transforms
    [SerializeField]
    private GameObject[] enemyToSpawn;
    //Transforms

    //Floats
    [SerializeField]
    private float waitTime;
    //Floats

    //Vector2
    private Vector2 spawnPos;
    //Vector2

    //GameObjects
    private GameObject startWave;
    //GameObjects


	void Start () 
    {
        startWave = GameObject.Find("WaveButton");
        startWave.GetComponent<Button>().onClick.AddListener(InvokeEnemies);
	}

    void InvokeEnemies()
    {
        spawnPos = transform.position;
        InvokeRepeating("SpawnRepeater", 0, waitTime);
    }
	

    void SpawnRepeater()
    {
        Instantiate(enemyToSpawn[Random.Range(0, enemyToSpawn.Length)], new Vector2(spawnPos.x, spawnPos.y), Quaternion.identity);
    }
}
