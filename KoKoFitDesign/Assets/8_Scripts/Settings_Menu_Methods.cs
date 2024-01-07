using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings_Menu_Methods : MonoBehaviour
{
    // fuer den Button "Zurueck" in den Einstellungen
    // laedt Hauptmenueszene (Szene 0)
    public void Zurueck()
    {
        SceneManager.LoadSceneAsync(0);
    }

    // fuer den Button "X" (Beenden) in den Einstellungen
    // beendet die Anwendung
    public void Beenden()
    {
        Application.Quit();
    }
}
