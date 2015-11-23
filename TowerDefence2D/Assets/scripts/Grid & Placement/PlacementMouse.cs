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

    [SerializeField]
    private Transform turret;
    //Transforms

    [SerializeField]
    private LayerMask isTaken;

    //Vector2
    private Vector2 mousePosition;
    private Vector2 gridPos;
    //Vector2

    //Bool
    public bool building;
    private bool isFree;
    [SerializeField]
    private bool spawnWall = false;
    [SerializeField]
    private bool spawnTurret = false;
    //Bool

    private CoinsController checkCoins;
	
    void Update()
    {
        CheckMouse();
        PlaceInput();

        gridPos = new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid);
    }

    void CanIBuild()
    {
       if (checkCoins._coinsValue > 0)
       {
           building = true;
       }
    }


    void CheckMouse()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if (building)
        {
            transform.position = gridPos;
        }
        else transform.position = new Vector2(-10000, 0);
    }


    void PlaceInput()
    {
        if (building)
        {
            isFree = !(Physics2D.OverlapCircle(gridPos, (grid / 2), isTaken));
            if (isFree)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    if (spawnWall)
                    {
                        Instantiate(tower1, gridPos, Quaternion.identity);
                        checkCoins._coinsValue -= 500f;
                    }
                       
                    else if (spawnTurret)
                    {
                        Instantiate(turret, gridPos, Quaternion.identity);
                        checkCoins._coinsValue -= 500f;
                    }
                        
                }
            }
        }
    }
}
    