using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SouthAmericaScript : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(23);
    }
}
