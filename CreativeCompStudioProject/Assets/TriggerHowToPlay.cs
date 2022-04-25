using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHowToPlay : MonoBehaviour
{
    //public string flute = "FluteWin";
    //public string trumpet = "TrumpetWin";

    public void OnButtonPress()
    {
        //PlayerPrefs.SetInt(flute,0);
        //PlayerPrefs.SetInt(trumpet,0);
        SceneManager.LoadScene(22);
    }
}
