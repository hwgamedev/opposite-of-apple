using UnityEngine;
using System.Collections;

public class FlyAcross : MonoBehaviour {


	public float verticalForce = 150f;
	public float horizontalForce = 500f;
	public bool startLeft = true;

	// Use this for initialization
	void Start () {
		if (!startLeft)
		{
			horizontalForce = -horizontalForce;
		}
		SingleArc ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SingleArc ()
	{
		rigidbody2D.AddForce(new Vector2(horizontalForce, verticalForce));
	}
}
