using UnityEngine;
using System.Collections;

public class PopUpGoDown : MonoBehaviour {

	//distance that the apple travels to pop up
	public float popUpDistance = 100f;

	//vertical distance to original spawn point
	public float distanceToOrigin = 0;

	//time that apple stays popped up
	public float popUpTime = 3;
	public float verticalSpeed = 3f;
	bool isPoppedUp = false;
	bool isBackDown = false;

	//difficulty multiplier update
	private TimeManager tm;
	private float originY;

	void Start () {
		tm = GameObject.FindGameObjectWithTag ("TimeManager").GetComponent<TimeManager> ();
		originY = rigidbody2D.position.y;
	}

	void Update () {

		if (!isPoppedUp)
		{
			PopUp ();
		}else
			{
				popUpTime -= Time.deltaTime*tm.getDifficultyModifier();
			}
		if (popUpTime <= 0 && !isBackDown)
		{
			GoDown ();
		}
		if (isBackDown)
		{
			DestroyObject(gameObject);
		}
		if(isPoppedUp){
			if (rigidbody2D.position.y < originY)
			{
				DestroyObject(gameObject);
			}
		}
	
	}

	void PopUp(){
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, verticalSpeed);
		distanceToOrigin += verticalSpeed;
		if(distanceToOrigin >= popUpDistance)
		{
			isPoppedUp = true;
			rigidbody2D.velocity = new Vector2 (0, 0);
		}
	}
	void GoDown(){
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, -verticalSpeed);
		distanceToOrigin -= verticalSpeed;
		if(distanceToOrigin <= 0)
		{
			isBackDown = true;
			rigidbody2D.velocity = new Vector2 (0, 0);
		}
	}

}
