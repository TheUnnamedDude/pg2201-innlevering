   using UnityEngine;
    using System.Collections;
   using System.Reflection;
   using System.Security.Cryptography.X509Certificates;

public class PaddleController : MonoBehaviour {
    public const float normalSpeed = 20f;
    public const float fastSpeed = 50f;
    private Vector3 defaultPosition;

    void Awake()
    {
        defaultPosition = transform.position;
    }

    public void Reset()
    {
        transform.position = defaultPosition;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var pos = transform.position;
            pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            transform.position = pos;
        }
        else
        {
            var currentMovementSpeed = Input.GetKey(KeyCode.LeftShift) ? fastSpeed : normalSpeed;
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * currentMovementSpeed * Time.deltaTime, 0));
        }
        var leftWallBounds = GameObject.Find("LeftWall").collider2D.bounds;
        var rightWallBounds = GameObject.Find("RightWall").collider2D.bounds;
        var paddleBounds = collider2D.bounds;
        var p = transform.position;
        if (paddleBounds.min.x < leftWallBounds.max.x)
        {
            p.x = leftWallBounds.max.x + paddleBounds.size.x / 2;
        }
        else if (paddleBounds.max.x > rightWallBounds.min.x)
        {
            p.x = rightWallBounds.min.x - paddleBounds.size.x / 2;
        }
        transform.position = p;
    }
}
