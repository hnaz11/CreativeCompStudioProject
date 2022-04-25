using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentsUnlockedScript : MonoBehaviour
{
    public GameObject TRUMPET, FLUTE;
    int trumpetWin, fluteWin;
    // Start is called before the first frame update
    void Start()
    {
        trumpetWin = PlayerPrefs.GetInt("TrumpetWin");
        fluteWin = PlayerPrefs.GetInt("FluteWin");
        //Debug.Log("TRUMPET IS " + trumpetWin);
        //Debug.Log("FLUTE IS " + fluteWin);

        if(trumpetWin == 1)
            TRUMPET.SetActive(true);
        else
            TRUMPET.SetActive(false);

        if(fluteWin == 1)
            FLUTE.SetActive(true);
        else
            FLUTE.SetActive(false);
        
        
    }
}
