using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	private int score = 10;
	private Text display;
	
	public void incScore(int d) {
		score += d;

		if (score < 0) {
			Application.LoadLevel("Restart");
		}
	}
	
	public void resetScore() {
		score = 0;
	}
	
	// Use this for initialization
	void Start () {
		display = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		display.text = "" + score;
	}
}
