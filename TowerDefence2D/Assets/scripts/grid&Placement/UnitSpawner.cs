using UnityEngine;
using System.Collections;

public class UnitSpawner : MonoBehaviour {

    [SerializeField]
    private Transform enemy1;
    [SerializeField]
    private float waitTime;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnRepeater", 0, waitTime);
	}
	
	// Update is called once per frame
	void Update () {

	}
    void spawnRepeater()
    {
        Instantiate(enemy1, new Vector2(-40, 0), Quaternion.identity);
    }
}
