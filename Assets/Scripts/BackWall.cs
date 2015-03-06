using UnityEngine;

public class BackWall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("Paddle").transform.localScale = new Vector3(1.5f, 2, 1);
    }
}
