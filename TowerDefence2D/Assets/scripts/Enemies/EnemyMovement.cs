using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    private Vector2 movementSpeed;

    void Start()
    {
        movementSpeed = new Vector2(5, 0);
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        this.GetComponent<Rigidbody2D>().AddForce(movementSpeed);
    }
}
