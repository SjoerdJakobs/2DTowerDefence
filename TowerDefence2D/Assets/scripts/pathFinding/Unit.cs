using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
	private float speed = 10;
<<<<<<< HEAD
    //private bool reset = false;
	Vector3[] path;
	private int targetIndex;

    public event System.Action noPath;
    
=======
    private bool reset = false;
	Vector3[] path;
	private int targetIndex;

>>>>>>> 749407c0ee6f945bd8fe4913017220434bc57497
    void Start()
    {
        PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
        //StartCoroutine("DynamicPath"); //maybe for dynamic
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
<<<<<<< HEAD
            Debug.Log("path");
=======
>>>>>>> 749407c0ee6f945bd8fe4913017220434bc57497
            path = newPath;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
<<<<<<< HEAD
        else
        {
            if (noPath != null)
            {
                noPath();
            }
            Debug.Log("test");
            GameObject.Destroy(gameObject);
        }
=======
>>>>>>> 749407c0ee6f945bd8fe4913017220434bc57497
	}
    /*void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StopCoroutine("DynamicPath");
            StartCoroutine("DynamicPath");
        }
    }
<<<<<<< HEAD
    IEnumerator DynamicPath()
=======
    /*IEnumerator DynamicPath()
>>>>>>> 749407c0ee6f945bd8fe4913017220434bc57497
    {
        //float RefreshTime = .5f;
        while (true)
        {
            reset = true;
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
            yield break;
            //yield return new WaitForSeconds(RefreshTime);
        }
<<<<<<< HEAD
    }*/
    //maybe for dynamic
=======
    }*///maybe for dynamic
>>>>>>> 749407c0ee6f945bd8fe4913017220434bc57497
	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];

		while (true) {
            /*if (reset)
            {
                reset = false;
                targetIndex = 0;
                currentWaypoint = path[targetIndex];
                path = new Vector3[0];
            }*///maybe for dynamic
            if (transform.position == currentWaypoint) {
                //StopCoroutine("DynamicPath");
                //StartCoroutine("DynamicPath");
				targetIndex ++;
                if (targetIndex >= path.Length /*&& !reset*/)
                {
                    targetIndex = 0;
                    path = new Vector3[0];
                    //yield break;
                }
                currentWaypoint = path[targetIndex];
			}
			transform.position = Vector3.MoveTowards(transform.position,currentWaypoint,speed * Time.deltaTime);
			yield return null;
		}
       
    }
	

	public void OnDrawGizmos() {
		if (path != null) {
			for (int i = targetIndex; i < path.Length; i ++) {
				Gizmos.color = Color.black;
				Gizmos.DrawCube(path[i], Vector3.one);

				if (i == targetIndex) {
					Gizmos.DrawLine(transform.position, path[i]);
				}
				else {
					Gizmos.DrawLine(path[i-1],path[i]);
				}
			}
		}
	}
}
