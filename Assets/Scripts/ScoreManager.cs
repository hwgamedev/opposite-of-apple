using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	private int score = 10;
	private Text display;

	//reference for time manager
	private TimeManager tm;
	
	public void incScore(int d) {

		score += d;
		tm.incGameTime (d);

		if (score < 0) {
			Application.LoadLevel("Restart");
		}
	}
	
	public void resetScore() {
		score = 0;
		tm.reset ();
	}
	
	// Use this for initialization
	void Start () {
		display = GetComponent<Text> ();
		tm = GameObject.FindObjectOfType<TimeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		display.text = "" + score;
	}
}
