using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinalScore : MonoBehaviour {

	public Text scoreText;
	private GameManager scoreObject;

	// Use this for initialization
	void Start () {
		scoreObject = FindObjectOfType<GameManager> ();
		scoreText.text = "Your Score: " + scoreObject.GetScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
