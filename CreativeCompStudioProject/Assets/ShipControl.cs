using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipControl : MonoBehaviour
{
    public static float fireRate = 1f;
    public static float nextFire = 0.0f;
    public static float maxBullets = 10.0f; // max fire rate 
    public static bool isTrue = false;
    public Text gameOver;
    public Button restart;
    public static bool isGameActive = true;
    public static int lives = 3;

    void Start(){
        gameOver.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
    }

    void Update(){
        // allows for the ship to follow mouse
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
        // if left click will shoot
        if(Input.GetMouseButton(0) && Time.time > nextFire){
            nextFire = Time.time + (1/fireRate);
            Shoot();
        }
        if(lives <= 0){
            GameOver();
        }
    }
    
    void Shoot(){
       GameObject bul = ObjectPool.Instance.GetObjectFromPool("bullets");
       if(bul != null){
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
       }
       // if side ship gets attached to main ship
       if(isTrue == true){
           // goes through each child of parent ship
            foreach(Transform eachChild in transform){
                if(eachChild.tag == "sideship"){
                    GameObject bulP = ObjectPool.Instance.GetObjectFromPool("bullets");
                    if(bulP != null){
                        bulP.transform.position = eachChild.position;
                        bulP.transform.rotation = eachChild.rotation;
                        bulP.SetActive(true);
                    }
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D o){
        hit(o);
    }

    // when ship comes into contact with enemy it "destroys" it
    public static void hit(Collider2D o){
        if(o.gameObject.tag == "enemy"){
            Debug.Log("enemy hit");
            ScoreScript.scoreValue += 1;
            lives -= 1;
            o.gameObject.SetActive(false);
        }
        if(o.gameObject.tag == "speedup"){
            Debug.Log("speedup hit");
            o.gameObject.SetActive(false);
            // will not go over max of 10 bullets per second
            if(fireRate < maxBullets){
                // increase by 1 bullet per second
                fireRate += 1.0f;
            }
        }
    }

    public void GameOver(){
        gameOver.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
        gameOver.text = "Game Over! Final Score: " + ScoreScript.scoreValue;
        isGameActive = false;
    }

    public void RestartGame(){
        SceneManager.LoadScene("SampleScene");
        isGameActive = true;
        ScoreScript.scoreValue = 0;
        lives = 3;
    }
}
