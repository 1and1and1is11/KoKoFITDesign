using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings_Menu_Methods : MonoBehaviour
{
    public Slider schwierigkeit_slider;
    public Text schwierigkeit_text; 
    public Slider runden_slider;
    public Text runden_text;
    public Slider lautstaerke_slider;
    public Text lautstaerke_text;

    // wird ausgeführt, sobald die Szene aufgerufen wird
    // die darin aufgerufenen Methoden bewirken,
    // dass die dynamischen Textfelder der Slider Inhalte zeigen,
    // bevor der Slider bewegt wurde
    public void Start()
    {
        UpdateSchwierigkeitSlider(schwierigkeit_slider.value);
        UpdateRundenSlider(runden_slider.value);
        UpdateLautstaerkeSlider(runden_slider.value);
    }

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

    // wird der Schwierigkeit-SLider bewegt,
    // ändert sich die Schwierigkeitsangabe neben dem Slider
    public void UpdateSchwierigkeitSlider(float sliderwert)
    {
        switch (sliderwert)
        {
            case 0:
                schwierigkeit_text.text = "Einfach";
                break;
            case 1:
                schwierigkeit_text.text = "Einfach-Mittel";
                break;
            case 2:
                schwierigkeit_text.text = "Mittel";
                break;
            case 3:
                schwierigkeit_text.text = "Mittel-Schwer";
                break;
            case 4:
                schwierigkeit_text.text = "Schwer";
                break;
            default:
                print("Fehler im Skript Settings_Menu_Methods (switch case)");
                break;
        }

    }

    // wird der Runden-SLider bewegt, ändert sich die Zahl neben dem Slider
    public void UpdateRundenSlider(float sliderwert)
    {
        runden_text.text = sliderwert + " ";
    }

    // wird der Lautstaerke-SLider bewegt, ändert sich die Prozentangabe neben dem Slider
    public void UpdateLautstaerkeSlider(float sliderwert)
    {
        lautstaerke_text.text = sliderwert * 10 + " %";
    }
    

}
