using UnityEngine;
using System.Collections;

public class FollowTango : MonoBehaviour {

	public GameObject tangoPose;
	private Vector3 initialPosition;

	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = initialPosition + (tangoPose.transform.position);
		transform.rotation = tangoPose.transform.rotation;
	}
}
