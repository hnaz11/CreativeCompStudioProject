using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private float countEnemy = 2;
    private float countSide = 2;
    private float countSpeed = 2;
    // spawn rate that is adjustable
    public float SpawnRateEnemy = 2;
    public float SpawnRateSpeedUps = 2;
    public float SpawnRateSideShips = 2;
    // used for side ship spawning
    public static int powerupSpawn = 0;
    private Vector3 top;
 
    void Update(){
        if(ShipControl.isGameActive){
            top = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
            countEnemy -= Time.deltaTime;
            countSide -= Time.deltaTime;
            countSpeed -= Time.deltaTime;
            if(countEnemy <= 0){  
                SpawnEnemy();
                countEnemy = SpawnRateEnemy;
            }
            if(countSide <= 0){
                SpawnSideShips();
                countSide = SpawnRateSideShips;
            }
            if(countSpeed <= 0){
                SpawnSpeedUps();
                countSpeed = SpawnRateSpeedUps;
            }
        }
    }
    // spawn enemies
    void SpawnEnemy(){
        GameObject e = ObjectPool.Instance.GetObjectFromPool("enemy");
        if(e != null){
            e.transform.position = new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x), top.y+2, 0);
            e.transform.rotation = Quaternion.identity;
            e.SetActive(true);
        }
    }
    // spawn speed ups
    void SpawnSpeedUps(){
        GameObject s = ObjectPool.Instance.GetObjectFromPool("speedup");
        if(s != null){
            s.transform.position = new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x), top.y+2, 0);
            s.transform.rotation = Quaternion.identity;
            s.SetActive(true);
        }
    }
    // spawn side ships
    void SpawnSideShips(){
        if(powerupSpawn < 4){
            //Debug.Log("child num: " + powerupSpawn);
            GameObject p = ObjectPool.Instance.GetObjectFromPool("sideship");
            p.transform.position = new Vector3(Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x), top.y+2, 0);
            p.transform.rotation = Quaternion.identity;
            p.SetActive(true);
        }
    }
}
