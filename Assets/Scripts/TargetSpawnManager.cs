using UnityEngine;
using System.Collections;

public class TargetSpawnManager : MonoBehaviour {

	public GameObject appleTemplate;
	public GameObject flyingAppleTemplate;

    public GameObject burgerTemplate;
    public GameObject flyingBurgerTemplate;

    public GameObject cornTemplate;
    public GameObject flyingCornTemplate;


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
            switch(Random.Range(1,5))
            {
                case 1:
                    GameObject cornClone = (GameObject)Instantiate(cornTemplate, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
                    break;
                case 2:
                    GameObject burgerClone = (GameObject)Instantiate(burgerTemplate, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
                    break;
                case 3: case 4: case 5:
                    GameObject appleClone = (GameObject)Instantiate(appleTemplate, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }
			
		}
	}
}
