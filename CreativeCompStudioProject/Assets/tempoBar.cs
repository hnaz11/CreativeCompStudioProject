using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempoBar : MonoBehaviour
{
    //public Collider objectCollider;
    //public Collider otherCollider;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-5.75f, 0, 0);
       // objectCollider = gameObject.GetComponent<Collider>();
        //otherCollider = GameObject.FindGameObjectWithTag("Note").GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        //float horizontalInput = Input.GetAxis("Horizontal");

        //update the position
        transform.position = transform.position + new Vector3(2f * 2f * Time.deltaTime, 0, 0);
        if (transform.position.x > 6.25) {
        transform.position = new Vector3(-5.75f, 0, 0);
        }
    }

    void OnTriggerEnter(Collider trig) {
        //Debug.Log("uhh");
        if (trig.gameObject.GetComponent<customTag>().hasTag("active")) {
            //FMODUnity.RuntimeManager.PlayOneShot("event:/"+trig.gameObject.GetComponent<customTag>().getAtIndex(1), GetComponent<Transform>().position);
        }
    }
}
