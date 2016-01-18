using UnityEngine;
using System.Collections;

public class GeneralTargetsBehavior : MonoBehaviour {

	public GameObject[] targetSets;
	private int nextSet;

	// Use this for initialization
	void Start () {
		nextSet = 0;
		SetFinished ();
	}

	void SetFinished() {
		if (nextSet < targetSets.Length) {
			GameObject newTargetSet = Instantiate (targetSets [nextSet]);
			newTargetSet.transform.parent = this.gameObject.transform;
			newTargetSet.transform.localPosition = new Vector3 ();
			nextSet++;
		} else {
			Application.LoadLevel("End");
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
