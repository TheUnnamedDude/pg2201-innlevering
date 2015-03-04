using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public int collisioncounter = 0;
    public float moveSpeed = 7f;
    private Rigidbody2D ballRB;
    private bool isActive;
    private Vector3 defaultPosition;
	public AudioClip boop;

    private void Awake()
    {
        ballRB = GetComponent<Rigidbody2D>();
        defaultPosition = transform.position;
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1)) && isActive == false && !GameManager.Instance.Paused)
        {
            transform.parent = null;
            isActive = true;
            ballRB.isKinematic = false;
            rigidbody2D.velocity = new Vector2(moveSpeed, moveSpeed);
        }
    }

    public void Reset()
    {
        rigidbody2D.velocity = Vector2.zero;
        isActive = false;
        transform.position = defaultPosition;
        transform.parent = GameObject.Find("Paddle").transform;
        collisioncounter = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        collisioncounter++;
        if (collisioncounter == 4)
        {
            rigidbody2D.AddForce(rigidbody2D.velocity.normalized * 0.025f);
        }
        else if (collisioncounter == 12)
        {
            rigidbody2D.AddForce(rigidbody2D.velocity.normalized * 0.025f);
        }
		audio.PlayOneShot (boop);
    }
}