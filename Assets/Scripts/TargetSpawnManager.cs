using UnityEngine;
using System.Collections;

public class TargetSpawnManager : MonoBehaviour {

	public GameObject appleTemplate;
	public float spawnInterval;


	private GameObject[] spawnPoints;
	private float countDown;

	// Use this for initialization
	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		//print ("No of spawnPoints: " + spawnPoints.Length);
		countDown = spawnInterval;
	}
	
	// Update is called once per frame
	void Update () {
	
		countDown -= Time.deltaTime;

		if (countDown <= 0) {
			countDown = spawnInterval;
			int spawnPointNo = Random.Range (0,spawnPoints.Length);
			GameObject appleClone = (GameObject) Instantiate (appleTemplate, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
		}
	}
}
