using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(4);
        Debug.Log("triggered....");
    }
}
