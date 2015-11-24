using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    public float _Enemyhealth = 100f;
    private GameObject _healthBar;

	void Start () 
    {
        
	}
	

	void Update () 
    {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Bullet")
        {
            Debug.Log("Hit");
            _healthBar = GameObject.Find("HealthBar");
            Destroy(other.gameObject);
            _Enemyhealth -= 50;
        }
    }
}
