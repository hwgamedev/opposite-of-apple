using UnityEngine;
using System.Collections;

public class DestroyChunks : MonoBehaviour {
    bool seen = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (renderer.isVisible) seen = true;
        if (seen && !renderer.isVisible)
        {
            Destroy(gameObject);
        }
	}
}
