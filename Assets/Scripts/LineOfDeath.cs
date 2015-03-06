using UnityEngine;

public class LineOfDeath : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other == GameObject.Find("Sphere"))
            GameObject.Find("Paddle").transform.localScale = new Vector3(2, 2, 1);
        GameManager.Instance.OnDeath();
    }
}
