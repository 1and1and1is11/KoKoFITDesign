using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_Methods : MonoBehaviour
{
    [SerializeField]    GameObject  Abfragefeld;
    public              Text        Frage;
    public              InputField  Name;

    // fuer den Button "Weiter" im Hauptmenue
    // [TODO] ruft aktuell immer das Abfragefenster auf, dass der Name bereitsvorhanden sei
    public void Weiter()
    {
       Abfragefeld.SetActive(true);
    }

    //
    //
    public void Fragetext()
    {
        if (Name.text != "")
        {
            Frage.text = "Der Name " + Name.text + " existiert bereits. Möchten Sie damit weiter spielen?";
        }
        else
        {
            Frage.text = "Es wurde kein Name eingegeben. Trotzdem spielen?";
        }
            
    }

    // fuer den Button "Nein" im Abfragefenster "Name bereits vorhanden. Damit weiterspielen?"
    // versteckt das Abfragefenster wieder
    public void Nein()
    {
       Abfragefeld.SetActive(false);
    }

    // fuer den Button "Ja" im Abfragefenster "Name bereits vorhanden. Damit weiterspielen?"
    // laedt Einstellungsszene
    public void Ja()
    {
       SceneManager.LoadSceneAsync("Settings_example"); 
    }

    // fuer den Button "X" (Beenden) im Hauptmenue
    // beendet die Anwendung
    public void Beenden()
    {
        Application.Quit();
    }

}
