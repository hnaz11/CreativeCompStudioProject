using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howtoplayTrigger : MonoBehaviour
{
    public void OnButtonPress(){
        SceneManager.LoadScene(22);
    }
}
