using UnityEngine;
using System.Collections;

public class SetBehavior : MonoBehaviour {

	private int setCount;

	// Use this for initialization
	void Start () {
		setCount = transform.childCount;
		Debug.Log ("initial count: " + setCount);
	}

	void kill (GameManager scores) {
		setCount--;
		if (setCount == 0) {
			scores.score(100);
			transform.parent.SendMessage("SetFinished");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
