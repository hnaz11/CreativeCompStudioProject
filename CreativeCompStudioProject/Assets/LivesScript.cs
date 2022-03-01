using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    public static int livesLeft = 3;
    Text lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(livesLeft < 0){
            livesLeft = 0;
        }
        lives.text = "Lives left: " + livesLeft;
        
    }
}
