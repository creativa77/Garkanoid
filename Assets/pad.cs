using UnityEngine;
using System.Collections;

public class pad : MonoBehaviour {

	public int padSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float displacement = Input.GetAxis ("Horizontal");
		transform.Translate (displacement * padSpeed * Time.deltaTime, 0, 0);
		displacement = Input.GetAxis ("Vertical");
		transform.Translate (0, displacement * padSpeed * Time.deltaTime, 0);
		displacement = Input.GetAxis ("Travel");
		transform.Translate (0, 0, displacement * padSpeed * Time.deltaTime);
	}
}
