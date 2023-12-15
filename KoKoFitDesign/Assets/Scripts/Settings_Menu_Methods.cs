using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings_Menu_Methods : MonoBehaviour
{
    // fuer den Button "Zurueck" in den Einstellungen
    // laedt Hauptmenueszene
    public void Zurueck()
    {
        SceneManager.LoadSceneAsync("Main_Menu");
    }

    // fuer den Button "X" (Beenden) in den Einstellungen
    // beendet die Anwendung
    public void Beenden()
    {
        Application.Quit();
    }
}
