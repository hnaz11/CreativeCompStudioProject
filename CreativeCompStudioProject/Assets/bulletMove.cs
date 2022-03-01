using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D objRigidbody;

    // Use this for initialization
    public void OnEnable () {
	    objRigidbody = transform.GetComponent<Rigidbody2D>();
	    objRigidbody.velocity = transform.up * speed;
    }
    // if bullet hits enemy or leaves screen will be set to not active 
    void OnTriggerExit2D(Collider2D o){
        if(o.gameObject.tag == "enemy"){
            ScoreScript.scoreValue += 1;
            o.gameObject.SetActive(false);
        }
        if (o.gameObject.tag == "Top") {
          gameObject.SetActive(false);
        }
    }
}
