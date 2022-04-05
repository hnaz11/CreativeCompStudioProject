using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    int x;
    public void OnButtonPress(){
        x++;
        Debug.Log("button clicked " + x + " times!!");
    }
}
