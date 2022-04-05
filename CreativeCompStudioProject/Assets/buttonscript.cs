using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonscript : MonoBehaviour
{
    int x;
    public void OnButtonPress(){
        x++;
        Debug.Log("button clicked " + x + " times!!");
        SceneManager.LoadScene(4);
    }
}
