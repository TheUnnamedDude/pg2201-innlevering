using UnityEngine;

public class CubeRemover : MonoBehaviour
{
    public int pointsWorth = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(GameObject.Find("PS"), transform.position, Quaternion.identity);
        GameManager.Instance.Score += pointsWorth;
        GameManager.Instance.CubeRemoved();
        Destroy(gameObject);
    }
}
