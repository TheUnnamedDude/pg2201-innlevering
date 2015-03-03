using System;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const int numberOfCubes = 88;

    public int CubesRemoved
    {
        get;
        set;
    }

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
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void OnDeath()
    {
        Lifes--;
        if (Instance.Lifes <= 0)
        {
            // TODO: Game over
        }
        GameObject.Find("Life").GetComponent<TextMesh>().text = String.Format("Life(s): {0}", Lifes);
    }

    public void CubeRemoved()
    {
        CubesRemoved--;
        GameObject.Find("Score").GetComponent<TextMesh>().text = string.Format("Score: {0}", Score);
        if (numberOfCubes - CubesRemoved <= 0)
        {
            // TODO: Wonnededed!
            Debug.Log("You wonnededededed");
        }
    }
}
