using UnityEngine;
using System.Collections;

public class BackWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnCollisionEnter2D (Collision2D other)
    {
        GameObject.Find("Paddle").transform.localScale = new Vector3(4, 1, 1);
    }
}
