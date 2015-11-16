using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
	private float speed = 10;
    private bool reset = false;
	Vector3[] path;
	int targetIndex;

    void Start()
    {
        StartCoroutine("DynamicPath");
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
            path = newPath;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
	}
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StopCoroutine("DynamicPath");
            StartCoroutine("DynamicPath");
        }
    }
    IEnumerator DynamicPath()
    {
        float RefreshTime = .5f;
        while (true)
        {
            reset = true;
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
            //yield break;
            yield return new WaitForSeconds(RefreshTime);
        }
    }
	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];

		while (true) {
            if (reset)
            {
                reset = false;
                targetIndex = 0;
                if (targetIndex < path.Length)
                {
                    targetIndex--;
                }
                currentWaypoint = path[targetIndex];
                path = new Vector3[0];
            }
            if (transform.position == currentWaypoint) {
				targetIndex ++;
                if (targetIndex >= path.Length && !reset)
                {
                    targetIndex = 0;
                    path = new Vector3[0];
                    yield break;
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
