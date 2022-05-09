using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goBackInst : MonoBehaviour
{
    public void OnButtonPress(){
        SceneManager.LoadScene(28);
    }

}
