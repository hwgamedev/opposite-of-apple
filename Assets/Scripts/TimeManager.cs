using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float difficultyIncreaseTime;
	public float difficultyIncrease;
	public float timeMultiplier;
	public GameObject timeEffectTemplate;

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
		gameTimeIncrease /= 2;
		gameTime += gameTimeIncrease*timeMultiplier;
		GameObject timeEffectClone = (GameObject)Instantiate(timeEffectTemplate, new Vector3(transform.position.x+40, transform.position.y-10, transform.position.z), Quaternion.identity);
		timeEffectClone.transform.parent = transform;
		timeEffectClone.GetComponent<TimeEffect> ().number = gameTimeIncrease * timeMultiplier;

	}

	public void reset() {
		timePlayed = 0;
		difficultyMultiplier = 1;
		gameTime = startGameTime;
	}

	private void displayText() {
		timeDisplay.text = "Time: " + gameTime.ToString ("n2");
		}

}
