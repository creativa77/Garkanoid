using UnityEngine;
using System.Collections;

public class TargetBehavior : MonoBehaviour {

	public int points;

	// Use this for initialization
	void Start () {
		
	}

	void kill(GameManager scores) {
		scores.score (points);
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
	}
}
