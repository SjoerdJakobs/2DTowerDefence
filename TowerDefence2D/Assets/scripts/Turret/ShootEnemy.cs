﻿using UnityEngine;
using System.Collections;

public class ShootEnemy : MonoBehaviour {

    [SerializeField]
    private LayerMask enemyLayer;

    //GameObjects
    [SerializeField]
    private GameObject bulletObj;
    private GameObject closestEnemy;
    //GameObjects

    //Vector2
   private Vector2 bulletSpawnVec;
    //Vector2

    //Bool
    [SerializeField]
    private bool spotEnemy = false;
    //Bool

	void Start () 
    {
       InvokeRepeating("FindEnemy", 0, 1.5f);
	}


	void FindEnemy()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(this.gameObject.transform.position, 2f, enemyLayer);


        float shortestDistance = float.MaxValue;

        for (int i = 0; i < hitEnemies.Length; i++)
        {
            float distance = Vector2.Distance(this.gameObject.transform.position, hitEnemies[i].transform.position);

            if (distance < shortestDistance)
            {
                closestEnemy = hitEnemies[i].gameObject;
                shortestDistance = distance;
            }
        }

            if (closestEnemy != null)
            {
                ShootBullet();
            }

        
    }
   
    void SpawnBullets()
    {
        GameObject bulletToSpawn = Instantiate(bulletObj, transform.position, transform.rotation) as GameObject;
        bulletToSpawn.GetComponent<BulletMovement>().setTarget(closestEnemy);    
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.gameObject.transform.position, 2f);
    }

    void ShootBullet()
    {
        SpawnBullets();
    }
     
}
