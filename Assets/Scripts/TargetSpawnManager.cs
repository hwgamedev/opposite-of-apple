using UnityEngine;
using System.Collections;

public class TargetSpawnManager : MonoBehaviour {

	public GameObject appleTemplate;
	public GameObject flyingAppleTemplate;


	public float popUpSpawnInterval;
	public float flyingSpawnInterval;


	private GameObject[] spawnPoints;
	private float popUpCountDown;

	// Use this for initialization
	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		//print ("No of spawnPoints: " + spawnPoints.Length);
		popUpCountDown = popUpSpawnInterval;
	}
	
	// Update is called once per frame
	void Update () {
	
		PopUpSpawn ();
	}

	void PopUpSpawn ()
	{
		popUpCountDown -= Time.deltaTime;
		
		if (popUpCountDown <= 0) {
			popUpCountDown = popUpSpawnInterval;
			int spawnPointNo = Random.Range (0,spawnPoints.Length);
			GameObject appleClone = (GameObject) Instantiate (appleTemplate, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
		}
	}
}
