using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class instrumentTransitionButton : MonoBehaviour
{
    [SerializeField]
    private Camera pianoCam;
    [SerializeField]
    private Camera guitarCam;

    public void Start() {
        //Camera.main.enabled = false;
    }

    public void PianoPress() {
        pianoCam.enabled = true;
        Camera.main.enabled = false;
        Debug.Log("Piano Pressed!");
    }

    public void GuitarPress() {
        guitarCam.enabled = true;
        Camera.main.enabled = false;
    }
}
