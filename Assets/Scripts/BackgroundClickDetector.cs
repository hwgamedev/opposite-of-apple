using UnityEngine;
using System.Collections;

public class BackgroundClickDetector : MonoBehaviour {

	ScoreManager scoreManager;
	public int scoreChange;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindWithTag ("ScoreManager").GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			//scoreManager.incScore (-1);
		}
	}
	
}
