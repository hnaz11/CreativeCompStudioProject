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
    private GameObject pianoButton, guitarB, fluteB, diziB, sitarB, claveB, laB, manB, kalB;
    private GameObject trumpetB;
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

        // pianoButton = GameObject.FindWithTag("PianoButton");
        // guitarB = GameObject.FindWithTag("guitar");
        // trumpetB = GameObject.FindWithTag("trumpet");
        // fluteB = GameObject.FindWithTag("flute");
        // diziB = GameObject.FindWithTag("dizi");
        // sitarB = GameObject.FindWithTag("sitar");
        // claveB = GameObject.FindWithTag("clave");
        // laB = GameObject.FindWithTag("antara");
        // manB = GameObject.FindWithTag("mandole");
        // kalB = GameObject.FindWithTag("kalimba");
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
    }

    public void PianoPress() {
        //checkActiveButtons();
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

    // public void checkActiveButtons(){
    //     if(pianoWin != 1){
    //         //Debug.Log("PIANO");
    //         pianoButton.SetActive(false);
    //     }
    //     if(guitarWin != 1){
    //         guitarB.SetActive(false);
    //     }
    //     if(trumpetWin != 1){
    //         trumpetB.SetActive(false);
    //     }
    //     if(diziWin != 1){
    //         diziB.SetActive(false);
    //     }
    //     if(sitarWin != 1){
    //         sitarB.SetActive(false);
    //     }
    //     if(claveWin != 1){
    //         claveB.SetActive(false);
    //     }
    //     if(laWin != 1){
    //         laB.SetActive(false);
    //     }
    //     if(fluteWin != 1){
    //         fluteB.SetActive(false);
    //     }
    //     if(manWin != 1){
    //         manB.SetActive(false);
    //     }
    //     if(kalimbaWin != 1){
    //         kalB.SetActive(false);
    //     }

    // }
}
