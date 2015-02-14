using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public float difficultyIncreaseTime;
	public float difficultyIncrease;

	private float difficultyMultiplier;
	private float timePlayed;

	// Use this for initialization
	void Start () {
		timePlayed = 0;
		difficultyMultiplier = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timePlayed += Time.deltaTime;
		if (timePlayed >= difficultyIncreaseTime) {
			timePlayed = 0;
			difficultyMultiplier += difficultyIncrease;
		}
	}

	public float getDifficultyModifier() {
				return difficultyMultiplier;
		}
}
