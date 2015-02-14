using UnityEngine;
using System.Collections;

public class FlyAcross : MonoBehaviour {


	public float verticalForce = 150f;
	public float horizontalForce = 500f;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(new Vector2(horizontalForce, verticalForce));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SingleArc ()
	{
		rigidbody2D.AddForce(new Vector2(horizontalForce, verticalForce));
	}
}
