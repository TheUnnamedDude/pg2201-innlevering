   using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
    public float moveSpeed = 20f;
    public float boost = 100;

    void Update()
    {
        boost += Time.deltaTime * 3;
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.45f, 27.5f);
        transform.position = pos;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        while (Input.GetKey(KeyCode.LeftShift)
        {
            moveSpeed = 50f;
            boost -= Time.deltaTime * 1;
            if(boost == 0)
                moveSpeed =20f;
        }
           
    }
}
