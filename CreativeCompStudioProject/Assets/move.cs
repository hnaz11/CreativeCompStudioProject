using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D objRigidbody;
    public float speed;

    // Use this for initialization
    public void OnEnable() {
	    objRigidbody = transform.GetComponent<Rigidbody2D>();
	    objRigidbody.velocity = -transform.up * speed;
    }
}
