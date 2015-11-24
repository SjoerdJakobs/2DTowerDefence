using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    //Floats
<<<<<<< HEAD
    [SerializeField]
    private float _bulletVelocity;
=======
    private float bulletVelocity;
>>>>>>> e1a04b0ce83aa769f64919da7d54be7613022276
    //Floats

    //GameObjects
    private GameObject target;
    //GameObjects


    public void setTarget(GameObject obj)
    {
        target = obj;
    }

    void Start()
    {
        bulletVelocity = 5f * Time.deltaTime;
    }

    void Update()
    {
        if (target.gameObject != null)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, target.transform.position, bulletVelocity);
        }   
    }
}
