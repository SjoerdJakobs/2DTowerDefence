using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    //Floats
    private float bulletVelocity;
    //Floats

    //GameObjects
    private GameObject thisLoc;
    private GameObject enemyLoc;
    //GameObjects

    //Vector2
    private Vector2 enemyVec;
    private Vector2 thisVec;
    //Vector2

    void Start()
    {
        
        bulletVelocity = 70f;

        enemyLoc = GameObject.FindGameObjectWithTag("Enemy");
        thisLoc = GameObject.Find("BulletSpawner");
        thisVec = new Vector2(enemyLoc.transform.position.x, enemyLoc.transform.position.y);
        enemyVec = new Vector2(thisLoc.transform.position.x, thisLoc.transform.position.y);
    }
    
    void Update()
    {
       
        //Vector2.MoveTowards(thisVec, enemyVec, bulletVelocity);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Debug.Log("Test");
            this.gameObject.GetComponent<Rigidbody2D>().AddForce((enemyLoc.transform.position - transform.position) * bulletVelocity * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
