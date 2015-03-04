using System;
using UnityEngine;
using System.Collections;

public class CubeRemover : MonoBehaviour
{
    public int pointsWorth = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.Score += pointsWorth;
        GameManager.Instance.CubeRemoved();
        Destroy(gameObject);
    }
    
}
