using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipControl : MonoBehaviour
{
    public GameObject player;
    public static bool isTrue = false;
    public static bool isGameActive = true;

    void Update(){
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 position = this.transform.position;
                position.x--;
                this.transform.position = position;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 position = this.transform.position;
                position.x++;
                this.transform.position = position;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector3 position = this.transform.position;
                position.y++;
                this.transform.position = position;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector3 position = this.transform.position;
                position.y--;
                this.transform.position = position;
            }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // load different countries depending on tag
        if(other.tag == "Europe"){
            SceneManager.LoadScene(2);
        }
        if(other.tag == "Asia"){
            SceneManager.LoadScene(5);
        }
    }
}