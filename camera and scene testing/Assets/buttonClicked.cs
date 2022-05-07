using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonClicked : MonoBehaviour
{
    [SerializeField]
    public GameObject mainCam;

    [SerializeField]
    public GameObject secondCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam.SetActive(true);
       // secondCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainPress() {
        mainCam.SetActive(false);
        secondCam.SetActive(true);
        Debug.Log("main pressed!");
    }
}
