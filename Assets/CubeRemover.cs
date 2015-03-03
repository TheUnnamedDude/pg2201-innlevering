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
        Debug.Log(GameManager.Instance.Score);
        Destroy(gameObject);
    }
    
}
