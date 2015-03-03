using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score
    {
        get;
        set; 
    }

    private int _life = 3;
    public int Life
    {
        get { return _life; }
        set { _life += value; }
    }
    private static GameManager _instance;

    public static GameManager Instance
    {
        get { return _instance; }
    }

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale > 0 ? 0 : 1;
        }
    }

    public void OnDeath()
    {
        Life--;
        if (Life <= 0)
        {
            // TODO: Handle game over
        }
    }

}
