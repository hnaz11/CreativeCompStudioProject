using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentsUnlockedScript : MonoBehaviour
{
    public GameObject TRUMPET, FLUTE, PIANO, GUITAR, DIZI, SITAR, CLAVE, LAANTARA;
    public GameObject MANDALA, KALIMBA;
    int trumpetWin, fluteWin, guitarWin, pianoWin, diziWin, sitarWin, claveWin, laWin;
    int manWin, kalimbaWin;
    // Start is called before the first frame update
    void Start()
    {
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

        //Debug.Log("TRUMPET IS " + trumpetWin);
        //Debug.Log("FLUTE IS " + fluteWin);
        if (trumpetWin == 1)
            TRUMPET.SetActive(true);
        else
            TRUMPET.SetActive(false);

        if (fluteWin == 1)
            FLUTE.SetActive(true);
        else
            FLUTE.SetActive(false);
        if (guitarWin == 1)
            GUITAR.SetActive(true);
        else
            GUITAR.SetActive(false);
        if (pianoWin == 1)
            PIANO.SetActive(true);
        else
            PIANO.SetActive(false);
        if (diziWin == 1)
            DIZI.SetActive(true);
        else
            DIZI.SetActive(false);
        if (sitarWin == 1)
            SITAR.SetActive(true);
        else
            SITAR.SetActive(false);
        if (claveWin == 1)
            CLAVE.SetActive(true);
        else
            CLAVE.SetActive(false);
        if (laWin == 1)
            LAANTARA.SetActive(true);
        else
            LAANTARA.SetActive(false);
        if (manWin == 1)
            MANDALA.SetActive(true);
        else
            MANDALA.SetActive(false);
        if (kalimbaWin == 1)
            KALIMBA.SetActive(true);
        else
            KALIMBA.SetActive(false);
    }
}
