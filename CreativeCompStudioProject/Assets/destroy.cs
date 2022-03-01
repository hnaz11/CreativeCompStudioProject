using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // if leaves screen will set to inactive to be reused
    void OnTriggerExit2D(Collider2D other) {
	  if (other.gameObject.tag == "Bottom") {
          gameObject.SetActive(false);
      }
    } 
}
