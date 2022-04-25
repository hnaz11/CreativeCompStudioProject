using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour
{
    public string flute = "FluteWin";
    public string trumpet = "TrumpetWin";
    public string piano = "PianoWin";
    public string guitar = "GuitarWin";
    public string dizi = "DiziWin";
    public string sitar = "SitarWin";
    public string clave = "ClaveWin";
    public string la = "LaWin";
    public string man = "ManWin";
    public string kalimba = "KalimbaWin";

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(flute, 0);
        PlayerPrefs.SetInt(trumpet, 0);
        PlayerPrefs.SetInt(piano, 0);
        PlayerPrefs.SetInt(guitar, 0);
        PlayerPrefs.SetInt(dizi, 0);
        PlayerPrefs.SetInt(sitar, 0);
        PlayerPrefs.SetInt(clave, 0);
        PlayerPrefs.SetInt(la, 0);
        PlayerPrefs.SetInt(man, 0);
        PlayerPrefs.SetInt(kalimba, 0);

    }

    public void OnButtonPress()
    {
        SceneManager.LoadScene(22);
    }

    // Update is called once per frame
    void Update()
    {

    }
}