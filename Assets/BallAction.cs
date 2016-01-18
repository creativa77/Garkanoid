using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallAction : MonoBehaviour {

	public bool debug;
	public Vector3 initialSpeed;
	public GameObject gameScore;
	public int ballSpeed;
	public Animator uiAnimation;
	private GameManager myScore;
	private Vector3 speed;
	private Rigidbody ballBody;
	private AudioSource killSound;
	private AudioSource ballWallSound;
	private AudioSource ballPuckSound;

	// Use this for initialization
	void Start () {
		//speed = new Vector3(initialSpeed.x, initialSpeed.y, initialSpeed.z);
		myScore = gameScore.GetComponentInChildren<GameManager> ();
		ballBody = GetComponent<Rigidbody> ();
		ballBody.velocity = initialSpeed;

		AudioSource[] sounds = GetComponentsInChildren<AudioSource> ();
		for (int i = 0; i<sounds.Length; i++) {
			switch( sounds[i].name) {
			case "Kill Sound":
				killSound = sounds[i];
				break;
			case "Ball Wall":
				ballWallSound = sounds[i];
				break;
			case "Ball Puck":
				ballPuckSound = sounds[i];
				break;			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		// Make ball speed constant
		Vector3 v = ballBody.velocity;
		v.Normalize ();
		v.Scale (new Vector3(ballSpeed, ballSpeed, ballSpeed));
		ballBody.velocity = v;
	}

	void OnCollisionExit (Collision collision) {
		if (collision.gameObject.CompareTag ("target")) {
			killSound.Play();
			collision.gameObject.SendMessageUpwards("kill", myScore);
			// (collision.gameObject);
		}
		if (collision.gameObject.CompareTag ("wall")) {
			ballWallSound.Play();
			if (collision.gameObject.name == "Wall Back") {
				myScore.score(-1);
				uiAnimation.SetTrigger("Blink");
			}
		}
		if (collision.gameObject.name == "Puck") {
			collision.gameObject.GetComponent<Animator>().SetTrigger("Bounce");
			ballPuckSound.Play();
			// Handheld.Vibrate();
		}
	}
}
