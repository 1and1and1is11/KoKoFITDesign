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
    // setzt den Abfragewert auf "wahr", um Aktionen zu ermoeglichen
    // (etwa das Erscheinen des Abfragefensters)
    public void Weiter()
    {
       Abfragefeld.SetActive(true);
    }

    // ruft aktuell immer das Abfragefenster auf
    // ist Text ins Eingabefeld eingegeben?
    // Ja:      Fenstertext sagt, dass der Name bereits vorhanden sei;
    //          es gibt aber keine Pruefung, ob das ueberhaupt der Fall ist
    // Nein:    Fenstertext sagt, dass kein Name eingegeben worden sei
    //          und fragt, ob dennoch gespielt werden wolle
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

    // fuer den Button "Nein" im Abfragefenster
    //      "Name bereits vorhanden. Damit weiterspielen?" -> wenn Text ins Textfeld eingeben wurde
    //      "Kein Name eingegeben. Trotzdem spielen?" -> wenn kein Text ins Textfeld eingeben wurde
    // versteckt das Abfragefenster wieder
    public void Nein()
    {
       Abfragefeld.SetActive(false);
    }

    // fuer den Button "Ja" im Abfragefenster
    //      "Name bereits vorhanden. Damit weiterspielen?" -> wenn Text ins Textfeld eingeben wurde
    //      "Kein Name eingegeben. Trotzdem spielen?" -> wenn kein Text ins Textfeld eingeben wurde
    // laedt Einstellungsszene (Szene 1)
    public void Ja()
    {
       SceneManager.LoadSceneAsync(1);
    }

    // fuer den Button "X" (Beenden) im Hauptmenue
    // beendet die Anwendung
    public void Beenden()
    {
        Application.Quit();
    }

}
