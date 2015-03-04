using UnityEngine;
using System.Collections;

public class LineOfDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("Paddle").transform.localScale = new Vector3(2, 2, 1);
        GameManager.Instance.OnDeath();
    }
}
