using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class musicbuttonscript : MonoBehaviour
{
    int trumpetWin, fluteWin, guitarWin, pianoWin, diziWin, sitarWin, claveWin, laWin;
    int manWin, kalimbaWin;
    public Button button;

     void Start(){
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
        button = GetComponent<Button>();
    }

    public void OnButtonPress(){
        if(pianoWin == 1 && fluteWin == 1 && guitarWin == 1 && pianoWin == 1 && diziWin == 1 &&
            sitarWin == 1 && claveWin == 1 && laWin == 1 && manWin == 1 && kalimbaWin == 1){
            SceneManager.LoadScene(29);
        }else{
            button.interactable = false;
        }
    }
}
