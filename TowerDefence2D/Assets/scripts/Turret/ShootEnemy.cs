﻿using UnityEngine;
using System.Collections;

public class ShootEnemy : MonoBehaviour {

    //GameObjects
    [SerializeField]
    private GameObject bulletObj;
    private GameObject enemiestoFind;
    private GameObject bulletSpawnLoc;
    //GameObjects

    //Vector2
    private Vector2 bulletSpawnVec;
    //Vector2

	void Start () 
    {
        enemiestoFind = GameObject.FindGameObjectWithTag("Enemy");

        bulletSpawnLoc = GameObject.Find("BulletSpawner");
        bulletSpawnVec = new Vector2(bulletSpawnLoc.transform.position.x, bulletSpawnLoc.transform.position.y);

        
	}
	
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            StartCoroutine("ShootBullet");
        }
    }

    void SpawnBullets()
    {
        Instantiate(bulletObj, bulletSpawnVec, Quaternion.identity);
    }

    IEnumerator ShootBullet()
    {
        SpawnBullets();
        yield return new WaitForSeconds(2);
    }
}