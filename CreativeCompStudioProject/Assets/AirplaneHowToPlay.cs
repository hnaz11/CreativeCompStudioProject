using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AirplaneHowToPlay : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 target;

    void Start()
    {
        //initial coordinates for airplane are (3.1, 3.1, 0)
        target = new Vector3(-10, 3.1f, 0);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
