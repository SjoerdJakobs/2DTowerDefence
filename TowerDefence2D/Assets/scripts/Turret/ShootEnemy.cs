using UnityEngine;
using System.Collections;

public class ShootEnemy : MonoBehaviour {

    //GameObjects
    [SerializeField]
    private GameObject bulletObj;
    private GameObject[] enemiestoFind;
    private GameObject bulletSpawnLoc;
    //GameObjects

    //transform
    private Transform target;
    private Transform turret;
    private Transform bullet;
    [SerializeField]
    private Transform bulletSpawn;
    //transform

    //Vector2
    private Vector2 bulletSpawnVec;
    //Vector2

	void Start () 
    {
        enemiestoFind = GameObject.FindGameObjectsWithTag("Enemy");

        bulletSpawnLoc = GameObject.Find("BulletSpawner");
        bulletSpawnVec = new Vector2(bulletSpawnLoc.transform.position.x, bulletSpawnLoc.transform.position.y);


        foreach (GameObject enemy in enemiestoFind)
        {
            
        }
	}
	
    void OnTriggerStay2D (Collider2D other)
    {
        if (other.transform == target)
        {
            StartCoroutine("ShootBullet");
        }
    }

    void SpawnBullets()
    {
        Instantiate(bulletObj, bulletSpawn.position, Quaternion.identity);
    }

    IEnumerator ShootBullet()
    {
        SpawnBullets();
        yield return new WaitForSeconds(2);
    }
}
