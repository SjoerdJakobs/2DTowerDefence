using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
    //GameObjects
    private GameObject _TurretPlacement;
    private GameObject _WallPlacement;
    private GameObject _StartBuilding;
    //GameObjects


    void Start()
    {
        _StartBuilding = GameObject.Find("BuildButton");
        _StartBuilding.GetComponent<Button>().onClick.AddListener(ChangeBuild);
        _StartBuilding = GameObject.Find("WallButton");
        _StartBuilding.GetComponent<Button>().onClick.AddListener(ChangeWall);
        _StartBuilding = GameObject.Find("TowerButton");
        _StartBuilding.GetComponent<Button>().onClick.AddListener(ChangeTower);
    }

    void Update()
    {
        CheckMouse();
        PlaceInput();

        gridPos = new Vector2(Mathf.Round(mousePosition.x / grid) * grid, Mathf.Round(mousePosition.y / grid) * grid);
        /*if (GUI.Button(Rect,"BuildButton"))
        {

        }*/
    }

    void ChangeTower()
    {
        if (spawnTurret)
        {
            spawnTurret = false;
        }
        else
        {
            spawnTurret = true;
            spawnWall = false;
        }
            
    }
    void ChangeWall()
    {
        if (spawnWall)
        {
            spawnWall = false;
        }
        else
        {
            spawnTurret = false;
            spawnWall = true;
        }
    }
    void ChangeBuild()
    {
        spawnTurret = false;
        spawnWall = false;
        if (building)
        {
            building = false;
        }
        else
            building = true;
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
                        Instantiate(tower1, gridPos, Quaternion.identity);
                    else if (spawnTurret)
                        Instantiate(turret, gridPos, Quaternion.identity);
                }
            }
        }
    }
}
    