using System;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score
    {
        get;
        set; 
    }

    private int _lifes = 3;
    public int Lifes
    {
        get { return _lifes; }
        set { _lifes = value; }
    }

    public static GameManager Instance { get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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
        Lifes--;
        if (Instance.Lifes <= 0)
        {
            // TODO: Game over
        }
        GameObject.Find("Life").GetComponent<TextMesh>().text = String.Format("Life(s) left: {0}", Lifes);
    }

}
