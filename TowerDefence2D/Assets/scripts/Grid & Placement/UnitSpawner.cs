using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnitSpawner : MonoBehaviour {

    //Transforms
    [SerializeField]
    private GameObject[] _enemiesToSpawn;
    //Transforms

    //Floats
    [SerializeField]
    private float _waitTime;
    //Floats

    //Vector2
    private Vector2 _spawnPos;
    //Vector2

    //GameObjects
    private GameObject _startWave;
    //GameObjects


	void Start () 
    {
        _startWave = GameObject.Find("WaveButton");
        _startWave.GetComponent<Button>().onClick.AddListener(InvokeEnemies);
	}

    void Update ()
    {

    }

    void InvokeEnemies()
    {
        _spawnPos = transform.position;
        InvokeRepeating("SpawnRepeater", 0, _waitTime);
    }


    void SpawnRepeater()
    {
        Instantiate(_enemiesToSpawn[Random.Range(0, _enemiesToSpawn.Length)], new Vector2(_spawnPos.x, _spawnPos.y), Quaternion.identity);
    }
}
