using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public int collisioncounter = 0;
    public float moveSpeed = 7f;
    private Rigidbody2D ballRB;
    private bool isActive;

    private void Awake()
    {
        ballRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == false)
        {
            transform.parent = null;
            isActive = true;
            ballRB.isKinematic = false;
            rigidbody2D.velocity = new Vector2(moveSpeed, moveSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        collisioncounter++;
        if (collisioncounter == 4)
        {
            moveSpeed += 5;
            rigidbody2D.velocity = new Vector2(moveSpeed, moveSpeed);
        }
        else if (collisioncounter == 12)
        {
            moveSpeed += 5;
            rigidbody2D.velocity = new Vector2(moveSpeed, moveSpeed);
        }
    }
}