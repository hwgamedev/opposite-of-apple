﻿using UnityEngine;
using System.Collections;

public class AppleShoot : MonoBehaviour {
    public GameObject chunk1;
    public GameObject chunk2;
    public GameObject chunk3;
    public GameObject chunk4;
    public GameObject chunk5;
    public GameObject chunk6;

	public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindWithTag ("ScoreManager").GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		scoreManager.incScore (1);

        GameObject applechunk1 = Instantiate(chunk1, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk1.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk1.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

        GameObject applechunk2 = Instantiate(chunk2, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk2.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk2.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

        GameObject applechunk3 = Instantiate(chunk3, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk3.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk3.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

        GameObject applechunk4 = Instantiate(chunk4, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk4.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk4.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

        GameObject applechunk5 = Instantiate(chunk5, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk5.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk5.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

        GameObject applechunk6 = Instantiate(chunk6, new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0.0f), Quaternion.identity) as GameObject;
        applechunk6.rigidbody2D.AddForce(Vector3.right * Random.Range(-50, 50));
        applechunk6.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));

		Destroy (gameObject);

	}
}
