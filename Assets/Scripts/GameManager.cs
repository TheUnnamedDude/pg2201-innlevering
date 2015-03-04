using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int numberOfCubes = 88;
    public GameObject Menu;
    public Text StateText;
    public GameObject ContinueButton;

    public bool Paused { get; private set; }

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
            GUIToggle("Paused");
        }
        if (!Paused)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                ResetLevel();
            }
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
            GUIToggle("Game over", false);
            // TODO: Game over
            Debug.Log("GEIM OVR");
        }
        else
        {
            GameObject.Find("Paddle").GetComponent<PaddleController>().Reset();
            GameObject.Find("Sphere").GetComponent<Ball>().Reset();
        }
        GameObject.Find("Life").GetComponent<TextMesh>().text = String.Format("Life(s): {0}", Lifes);
    }

    public void CubeRemoved()
    {
        CubesRemoved++;
        GameObject.Find("Score").GetComponent<TextMesh>().text = string.Format("Score: {0}", Score);
        if (numberOfCubes - CubesRemoved <= 0)
        {
            GUIToggle(string.Format("You finished the game with {0} points", Score), false);
        }
    }
    public void GUIToggle(string title, bool showContinue = true)
    {
        Paused = !Paused;
        Time.timeScale = Paused ? 0 : 1;
        Menu.SetActive(Paused);
        ContinueButton.SetActive(showContinue);
        StateText.text = title;
    }
}
