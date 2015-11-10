using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    private float bulletVelocity;


    private GameObject enemyLoc;
    private Vector2 enemyVec;

    void Start()
    {
        enemyLoc = GameObject.FindGameObjectWithTag("Enemy");
        enemyVec = new Vector2(enemyLoc.transform.position.x, enemyLoc.transform.position.y);
    }
    
    void Update()
    {
        Vector2.MoveTowards(new Vector2(0, 0), enemyVec, 5f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            // Do Something!
        }
    }
}
