using System;
using UnityEngine;
using System.Collections;

public class CubeRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.Score++;
        GameObject score = GameObject.Find("Score");
        score.GetComponent<TextMesh>().text = string.Format("Score: {0}", GameManager.Instance.Score);
        Destroy(gameObject);
    }
    
}
