using UnityEngine;
using System.Collections;

public class TargetSpawnManager : MonoBehaviour {

	public GameObject appleTemplate1;
	public GameObject appleTemplate2;
	public GameObject flyingAppleTemplate;

    public GameObject burgerTemplate;
    public GameObject flyingBurgerTemplate;

    public GameObject cornTemplate;
    public GameObject flyingCornTemplate;


	public float popUpSpawnInterval;
	public float flyingSpawnInterval;


	private GameObject[] spawnPoints1;
	private GameObject[] spawnPoints2;
	private GameObject[] spawnPoints;
	private GameObject[] flyingSpawnLeft;
	private GameObject[] flyingSpawnRight;
	private GameObject[] flyingSpawnPoints;
	private float popUpCountDown;
	private float flyingCountDown;

	// Use this for initialization
	void Start () {
		spawnPoints1 = GameObject.FindGameObjectsWithTag ("SpawnPoint1");
		spawnPoints2 = GameObject.FindGameObjectsWithTag ("SpawnPoint2");
		flyingSpawnRight = GameObject.FindGameObjectsWithTag ("FlyingSpawnRight");
		flyingSpawnLeft = GameObject.FindGameObjectsWithTag ("FlyingSpawnLeft");

		//print ("No of spawnPoints: " + spawnPoints.Length);
		popUpCountDown = popUpSpawnInterval;
		flyingCountDown = flyingSpawnInterval;
	}
	
	// Update is called once per frame
	void Update () {
	
		PopUpSpawn ();
		FlyingSpawn ();
	}

	void PopUpSpawn ()
	{
		popUpCountDown -= Time.deltaTime;
		
		if (popUpCountDown <= 0) {
			popUpCountDown = popUpSpawnInterval;
			int layerNo=Random.Range(1,3);
			if (layerNo == 1)
			{
				spawnPoints = spawnPoints1;
			}else
			{
				spawnPoints = spawnPoints2;
			}
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
					if (layerNo == 1) {
                    GameObject appleClone = (GameObject)Instantiate(appleTemplate1, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
					}else{
					GameObject appleClone = (GameObject)Instantiate(appleTemplate2, spawnPoints[spawnPointNo].transform.position, Quaternion.identity);
					}
					break;
                default:
                    break;
            }
			
		}
	}

	void FlyingSpawn ()
	{
		flyingCountDown -= Time.deltaTime;
		
		if (flyingCountDown <= 0) {
			flyingCountDown = flyingSpawnInterval;
			int startSide=Random.Range(1,3);
			bool startLeft;
			if (startSide == 1)
			{
				flyingSpawnPoints = flyingSpawnLeft;
				startLeft = true;
			}else
			{
				flyingSpawnPoints = flyingSpawnRight;
				startLeft = false;
			}
			int spawnPointNo = Random.Range (0,flyingSpawnPoints.Length);
			FlyAcross fly;
			switch(Random.Range(1,5))
			{
			case 1:
				GameObject cornClone = (GameObject)Instantiate(flyingCornTemplate, flyingSpawnPoints[spawnPointNo].transform.position, Quaternion.identity);
				fly = cornClone.GetComponent<FlyAcross>();
				fly.startLeft = startLeft;
				break;
			case 2:
				GameObject burgerClone = (GameObject)Instantiate(flyingBurgerTemplate, flyingSpawnPoints[spawnPointNo].transform.position, Quaternion.identity);
				fly = burgerClone.GetComponent<FlyAcross>();
				fly.startLeft = startLeft;
				break;
			case 3: case 4: case 5:
				GameObject appleClone = (GameObject)Instantiate(flyingAppleTemplate, flyingSpawnPoints[spawnPointNo].transform.position, Quaternion.identity);
				fly = appleClone.GetComponent<FlyAcross>();
				fly.startLeft = startLeft;
				break;
			default:
				break;
			}
			
		}
	}
}
