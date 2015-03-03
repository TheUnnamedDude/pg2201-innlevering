   using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
    public const float normalSpeed = 20f;
    public const float fastSpeed = 50f;
    private float currentMovementSpeed = normalSpeed;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.45f, 27.5f);
        transform.position = pos;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * currentMovementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * currentMovementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
            currentMovementSpeed = fastSpeed;
        else currentMovementSpeed = normalSpeed;
    }
}
