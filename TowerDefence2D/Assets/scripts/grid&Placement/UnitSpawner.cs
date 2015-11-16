using UnityEngine;
using System.Collections;

public class UnitSpawner : MonoBehaviour {

    [SerializeField]
    private Transform enemy1;
    [SerializeField]
    private float waitTime;
    private Vector2 spawnPos;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnRepeater", 0, waitTime);
        spawnPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}
    void spawnRepeater()
    {
        Instantiate(enemy1, new Vector2(spawnPos.x, spawnPos.y), Quaternion.identity);
    }
}
