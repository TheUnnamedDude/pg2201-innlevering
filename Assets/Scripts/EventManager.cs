using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnContinuePressed()
    {
        GameManager.Instance.GUIToggle("Paused");
    }

    public void OnQuitPressed()
    {
        Application.LoadLevel(0);
    }

    public void OnRestartPressed()
    {
        GameManager.Instance.GUIToggle("Paused");
        GameManager.Instance.ResetLevel();
    }
}
