using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    //Floats
    [SerializeField]
    private float _bulletVelocity;
    //Floats

    //GameObjects
    private GameObject _bulletTarget;
    //GameObjects


    public void setTarget(GameObject obj)
    {
        _bulletTarget = obj;
    }

    void Start()
    {
        _bulletVelocity = 10f * Time.deltaTime;
    }

    void Update()
    {
        if (_bulletTarget.gameObject != null)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, _bulletTarget.transform.position, _bulletVelocity);
        }
    }
}
