using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float difficultyIncreaseTime;
	public float difficultyIncrease;
	public float timeMultiplier;

	//count down to game over
	public float gameTime;

	private float difficultyMultiplier;
	//Count down to difficulty increase
	private float timePlayed;

	//store a reference to the text componen
	private Text timeDisplay;

	//reference for resetting
	private float startGameTime;

	// Use this for initialization
	void Start () {
		timePlayed = 0;
		difficultyMultiplier = 1;
		startGameTime = gameTime;
		timeDisplay = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		gameTime -= Time.deltaTime;
		timePlayed += Time.deltaTime;
		if (timePlayed >= difficultyIncreaseTime) {
			timePlayed = 0;
			difficultyMultiplier += difficultyIncrease;
		}
		displayText ();

		if (gameTime <= 0) {
			Application.LoadLevel("Restart");
				}
	}

	public float getDifficultyModifier() {
				return difficultyMultiplier;
		}

	public void incGameTime(float gameTimeIncrease) {
		gameTime += gameTimeIncrease*timeMultiplier;
	}

	public void reset() {
		timePlayed = 0;
		difficultyMultiplier = 1;
		gameTime = startGameTime;
	}

	private void displayText() {
		timeDisplay.text = "Time: " + gameTime;
		}

}
