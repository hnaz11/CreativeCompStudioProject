using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class instrumentTransitionButton : MonoBehaviour
{
    [SerializeField]
    GameObject piano;
    [SerializeField]
    GameObject guitar;
    [SerializeField]
    GameObject dizi;
    [SerializeField]
    GameObject clave;
    [SerializeField]
    GameObject sitar;
    [SerializeField]
    GameObject antara;
    [SerializeField]
    GameObject flute;
    [SerializeField]
    GameObject trumpet;
    [SerializeField]
    GameObject mandole;
    [SerializeField]
    GameObject kalimba;

    private GameObject active;
    //private GameObject pianoButton, guitarB, trumpetB, fluteB, diziB, sitarB, claveB, laB, manB, kalB;
    int trumpetWin, fluteWin, guitarWin, pianoWin, diziWin, sitarWin, claveWin, laWin;
    int manWin, kalimbaWin;

    public void Start() {
        trumpetWin = PlayerPrefs.GetInt("TrumpetWin");
        fluteWin = PlayerPrefs.GetInt("FluteWin");
        guitarWin = PlayerPrefs.GetInt("GuitarWin");
        pianoWin = PlayerPrefs.GetInt("PianoWin");
        diziWin = PlayerPrefs.GetInt("DiziWin");
        sitarWin = PlayerPrefs.GetInt("SitarWin");
        claveWin = PlayerPrefs.GetInt("ClaveWin");
        laWin = PlayerPrefs.GetInt("LaWin");
        manWin = PlayerPrefs.GetInt("ManWin");
        kalimbaWin = PlayerPrefs.GetInt("KalimbaWin");
        //pianoButton = GameObject.Find("Piano Button");
        //guitarB = GameObject.Find("Guitar Button");

        guitar.SetActive(false);
        dizi.SetActive(false);
        sitar.SetActive(false);
        clave.SetActive(false);
        antara.SetActive(false); 
        flute.SetActive(false);
        trumpet.SetActive(false);
        mandole.SetActive(false);
        kalimba.SetActive(false);
        active = piano;
        // if(guitarWin == 1){
        //     guitar.SetActive(true);
        //     active = guitar;
        //     guitar.SetActive(false);
        //     dizi.SetActive(false);
        //     sitar.SetActive(false);
        //     clave.SetActive(false);
        //     antara.SetActive(false); 
        //     flute.SetActive(false);
        //     trumpet.SetActive(false);
        //     mandole.SetActive(false);
        //     kalimba.SetActive(false);
        //     if(pianoWin != 1){
        //         pianoButton.SetActive(false);
        //     }

        // }
    }

    public void PianoPress() {
        active.SetActive(false);
        piano.SetActive(true);
        active = piano;
    }

    public void GuitarPress() {
        active.SetActive(false);
        guitar.SetActive(true);
        active = guitar;
    }

    public void DiziPress() {
        active.SetActive(false);
        dizi.SetActive(true);
        active = dizi;
    }

    public void ClavePress() {
        active.SetActive(false);
        clave.SetActive(true);
        active = clave;
    }

    public void SitarPress() {
        active.SetActive(false);
        sitar.SetActive(true);
        active = sitar;
    }

    public void AntaraPress() {
        active.SetActive(false);
        antara.SetActive(true);
        active = antara;
    }

    public void FlutePress() {
        active.SetActive(false);
        flute.SetActive(true);
        active = flute;
    }

    public void TrumpetPress() {
        active.SetActive(false);
        trumpet.SetActive(true);
        active = trumpet;
    }

    public void MandolePress() {
        active.SetActive(false);
        mandole.SetActive(true);
        active = mandole;
    }

    public void KalimbaPress() {
        active.SetActive(false);
        kalimba.SetActive(true);
        active = kalimba;
    }
}
