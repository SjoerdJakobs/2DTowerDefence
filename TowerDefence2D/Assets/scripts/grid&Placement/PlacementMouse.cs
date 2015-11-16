using UnityEngine;
using System.Collections;

public class PlacementMouse : MonoBehaviour {

    [SerializeField]
    private int grid;

    [SerializeField]
    private Transform tower1;
    private Vector2 mousePosition;
	// Use this for initialization
	void Start () {
        
	    
	}
	
	// Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid);
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(tower1, new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid), Quaternion.identity);
        }
    }
}//Mathf.Round(Input.mousePosition.y / grid) * grid
    