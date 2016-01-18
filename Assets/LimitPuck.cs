using UnityEngine;
using System.Collections;

public class LimitPuck : MonoBehaviour {
	private float minZ;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;

	// Use this for initialization
	void Start () {
		minZ = transform.position.z;
	}

	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		bool updated = false;
		if (transform.position.z < minZ) {
			newPosition.z = minZ;
			updated = true;
		}
		if (transform.position.x < minX) {
			newPosition.x = minX;
			updated = true;
		}
		if (transform.position.x > maxX) {
			newPosition.x = maxX;
			updated = true;
		}
		if (transform.position.y < minY) {
			newPosition.y = minY;
			updated = true;
		}
		if (transform.position.y > maxY) {
			newPosition.y = maxY;
			updated = true;
		}
		if (updated) {
			transform.position = newPosition;
		}
	}
}
