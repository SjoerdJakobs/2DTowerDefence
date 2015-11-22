using UnityEngine;
using System.Collections;

public class PlacementMouse : MonoBehaviour {

    [SerializeField]
    private int grid;
    public bool building = true;
    [SerializeField]
    private Transform tower1;
    private Vector2 mousePosition;
    private bool spotTaken;
    private Vector2 gritPos;
    [SerializeField]
    private LayerMask unwalkableMask;
    private  Color color;//E85E5E63
	// Use this for initialization
	void Start () {
	}
    
	// Update is called once per frame
    void Update()
    {
        //if (building == true)
        //{
            //color.a = .63f;
            gritPos = new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid);
            if (Physics2D.OverlapCircle(gritPos, (grid / 2), unwalkableMask))
            {
                spotTaken = true;
                Debug.Log(spotTaken);
            }
            else
                spotTaken = false;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid);
            if (Input.GetButtonDown("Fire1") && spotTaken == false)
            {
                Instantiate(tower1, gritPos, Quaternion.identity);
            }
        //}
        //else
        //{
        //    color.a = 1.0f;
        //}
    }
}
    