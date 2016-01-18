using UnityEngine;
using System.Collections;

public class FollowPuck : MonoBehaviour {

	public GameObject puck;
	private Vector3 positionDelta;

	// Use this for initialization
	void Start () {
		positionDelta = transform.position - puck.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (puck.transform.position.x + positionDelta.x,
		                                 transform.position.y,
		                                 puck.transform.position.z + positionDelta.z);
	}
}
