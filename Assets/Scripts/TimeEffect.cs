using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeEffect : MonoBehaviour {

	private float fade;
	private Text textEffect;

	public float number = 0;

	// Use this for initialization
	void Start () {
		fade = 255;
		textEffect = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (number > 0) {
			textEffect.text = "+"+number+" sec";
		}
		else
			textEffect.text = number+" sec";
		fade -= Time.deltaTime*100;
		Color c = textEffect.material.color;
		c.a = fade;

		if (fade <= 0) {
			Destroy (gameObject);
		}
	}

	public void setText(float number) {
	}
}
