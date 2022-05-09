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

    private GameObject active;
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
        guitar.SetActive(false);
        dizi.SetActive(false);
        sitar.SetActive(false);
        clave.SetActive(false); 
        active = piano;
        // if(pianoWin == 1){
        //     active = piano;
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
}
