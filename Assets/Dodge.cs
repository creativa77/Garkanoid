using UnityEngine;
using System.Collections;

public class Dodge : MonoBehaviour {

	public float maxX = 0.9f;
	public float minX = -0.9f;
	
	private float direction = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > maxX) {
			direction = -1;
		}
		if (transform.position.x < minX) {
			direction = 1;
		}
		transform.Translate (new Vector3 (direction * Time.deltaTime, 0, 0));
	}
}
