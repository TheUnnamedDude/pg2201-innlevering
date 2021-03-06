﻿using UnityEngine;

//Brukte En "Sprint Bar" Tutorial for å lage denne koden.
//Adresse: https://www.youtube.com/watch?v=x9zOct1AMxo -Stuart Spence: "Unity3D - Sprinting and a Stamina Bar"

public class SlowMo : MonoBehaviour
{
    float SlowMoMax = 10f;
    public float SlowMoDecrease = 15f;
    public float SlowMoIncrease = 2f;
    float SlowMoCurrent = 10f;

    Rect SlowMoBar;
    Texture2D SlowMoTexture;

    //Definerer rektanglet som viser tilgjengelig slowmo - tid, og teksturen dens.
    void Start()
    {
        SlowMoBar = new Rect(Screen.width / 3, Screen.height * 19 / 20, Screen.width / 3, Screen.height / 50);
        SlowMoTexture = new Texture2D(1, 1);
        SlowMoTexture.SetPixel(0, 0, Color.white);
        SlowMoTexture.Apply();
    }

    //Ganske selvforklarende, setter på slowmo (timescale satt til 0.5) så lenge man har tilgjenelig slowmo (slowmocurrent over 0) og man holder inne midtre museknapp eller venstre control-knapp
    //SlowMo tjenes tilbake så lenge man ikke holder inne knappene og tilgjengelig slowmo-tid er mindre enn max slowmo-tid
    void Update()
    {
        if (!GameManager.Instance.Paused && (Input.GetMouseButton(2) || Input.GetKey(KeyCode.LeftControl)) && SlowMoCurrent >= 0)
        {

            Time.timeScale = 0.5f;
            if (SlowMoCurrent >= 0)
            {
                SlowMoCurrent -= SlowMoDecrease * Time.deltaTime;
            }
            //For å hindre uendelig slowmo sier jeg her at hvis man ikke har tilgjengelig slowmo eller man ikke holder nede knappene, eller om man holder nede knappene og ikke har slowmo,< så er timescale 1
        }
        else if (!GameManager.Instance.Paused && !(Input.GetMouseButton(2) || Input.GetKey(KeyCode.LeftControl) || SlowMoCurrent <= 0) || (Input.GetMouseButton(2) || Input.GetKey(KeyCode.LeftControl) && SlowMoCurrent <= 0))
        {
            Time.timeScale = 1;
        }
        if (SlowMoCurrent <= SlowMoMax)
        {
            SlowMoCurrent += SlowMoIncrease * Time.deltaTime;
        }


    }
    //Tegner rektangel som viser slowmobar på skjermen, og definerer vidden som tilgjengelig slowmo over max slowmo * skjermbredde / 3
    void OnGUI()
    {
        float filled = SlowMoCurrent / SlowMoMax;
        float SlowMoWidth = filled * Screen.width / 3;
        SlowMoBar.width = SlowMoWidth;
        GUI.DrawTexture(SlowMoBar, SlowMoTexture);
    }
}
