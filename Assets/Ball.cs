using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Rigidbody2D ballRB;
    private bool isActive;
	
    void Awake()
    {
        ballRB = GetComponent<Rigidbody2D>();
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == false)
        {
            transform.parent = null;
            isActive = true;
            ballRB.isKinematic = false;
            rigidbody2D.velocity = new Vector2(20, 6);
        }
            
	}
}
