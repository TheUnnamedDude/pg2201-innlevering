   using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
    public float moveSpeed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.45f, 27.5f);
        transform.position = pos;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
            moveSpeed = 50f;
        else moveSpeed = 10f;
    }
}
