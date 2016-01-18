using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	
	void Play() {
		Debug.Log ("play!");
		Application.LoadLevel ("Main Scene");
	}
}
