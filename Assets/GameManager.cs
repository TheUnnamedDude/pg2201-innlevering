using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score
    {
        get;
        set; 
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

}
