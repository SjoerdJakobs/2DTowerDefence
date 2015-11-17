using UnityEngine;
using System.Collections;

public class PlacementMouse : MonoBehaviour {

    //Int
    [SerializeField]
    private int grid;
    //Int

    //Transforms
    [SerializeField]
    private Transform tower1;
    //Transforms

    //Vector2
    private Vector2 mousePosition;
    //Vector2
	
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
    