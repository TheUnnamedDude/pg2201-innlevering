   using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
    public const float normalSpeed = 20f;
    public const float fastSpeed = 50f;
    private float currentMovementSpeed = normalSpeed;
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
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.45f, 27.5f);
        transform.position = pos;

        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * currentMovementSpeed * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.LeftShift))
            currentMovementSpeed = fastSpeed;
        else currentMovementSpeed = normalSpeed;
    }
}
