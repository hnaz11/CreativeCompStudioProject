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

    public void Start() {
        guitar.SetActive(false);
    }

    public void PianoPress() {
        guitar.SetActive(false);
        piano.SetActive(true);
        Debug.Log("Piano Pressed");
    }

    public void GuitarPress() {
        piano.SetActive(false);
        guitar.SetActive(true);
    }
}
