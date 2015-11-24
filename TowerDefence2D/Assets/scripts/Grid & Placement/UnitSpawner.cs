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
<<<<<<< HEAD
    private float _waitTime;
    private float _waveDuration;
=======
    private float waitTime;
>>>>>>> e1a04b0ce83aa769f64919da7d54be7613022276
    //Floats

   


    //Vector2
    private Vector2 spawnPos;
    //Vector2

    //GameObjects
    private GameObject startWave;
    //GameObjects


	void Start () 
    {
<<<<<<< HEAD
        _startWave = GameObject.Find("WaveButton");
        _startWave.GetComponent<Button>().onClick.AddListener(InvokeEnemies);
        _waveDuration = 10f;
    }
=======
        startWave = GameObject.Find("WaveButton");
        startWave.GetComponent<Button>().onClick.AddListener(InvokeEnemies);
	}
>>>>>>> e1a04b0ce83aa769f64919da7d54be7613022276

    void Update ()
    {

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
