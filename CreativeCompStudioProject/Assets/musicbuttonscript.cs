using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicbuttonscript : MonoBehaviour
{
    public void OnButtonPress(){
        SceneManager.LoadScene(27);
    }
}
