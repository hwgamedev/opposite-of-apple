using UnityEngine;
using System.Collections;

public class AppleShoot : MonoBehaviour {
    public GameObject chunk1;
    public GameObject chunk2;
    public GameObject chunk3;
    public GameObject chunk4;
    public GameObject chunk5;
    public GameObject chunk6;
    public AudioClip smash;

	private ScoreManager scoreManager;

    public int scoreChange;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindWithTag ("ScoreManager").GetComponent<ScoreManager>();
		rigidbody2D.AddTorque (30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

        audio.PlayOneShot(smash, 1.0F);
		scoreManager.incScore (scoreChange);

        GameObject applechunk1 = Instantiate(chunk1, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk1);

		GameObject applechunk2 = Instantiate(chunk2, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk2);

		GameObject applechunk3 = Instantiate(chunk3, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk3);

		GameObject applechunk4 = Instantiate(chunk4, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk4);

		GameObject applechunk5 = Instantiate(chunk5, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk5);

		GameObject applechunk6 = Instantiate(chunk6, transform.position, Quaternion.identity) as GameObject;
        forceApply(applechunk6);

		Destroy (gameObject);

	}

    void forceApply(GameObject x)
    {
        x.rigidbody2D.AddForce(Vector3.right * Random.Range(-25, 25));
        x.rigidbody2D.AddForce(Vector3.up * Random.Range(50, 200));
    }
}
