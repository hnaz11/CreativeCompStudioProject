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

    // void Start(){
    //     gameOver.gameObject.SetActive(false);
    //     restart.gameObject.SetActive(false);
    // }
    void Update(){
        // bool startMoving = false;
        // if (!startMoving && Input.GetMouseButton(0)) {
        //     Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     transform.position = pos;
        //     startMoving = true;  
        // }
        // // if left click will shoot
        // else if(Input.GetMouseButton(0) && startMoving){
        //     Vector3 p = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        //     if (!Input.GetMouseButton(0)) {
        //         transform.position = p;
        //         startMoving = false;
        //     }
        // }
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

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(1);
    }
}
