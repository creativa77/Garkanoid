using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Text ownScoreText;

	private int ownScoreValue = 0;

	void Start() {
		DontDestroyOnLoad(gameObject);
	}

	public void score(int points) {
		ownScoreValue += points;
		ownScoreText.text = "" + ownScoreValue;
	}

	public int GetScore() {
		return ownScoreValue;
	}
}
