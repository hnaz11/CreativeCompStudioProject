using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class airplaneMoveSA : MonoBehaviour
{
     public float speed = 2f;
     private Vector3 target;
     private Vector2 mouse;
 
     void Start () {
         target = transform.position;
     }
     
     void Update () {
         mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
         if (Input.GetMouseButtonDown(0) && mouse.x < Screen.width / 2 && mouse.y > Screen.height / 2) {
             target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             target.z = transform.position.z;
         }
         transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
     } 
}