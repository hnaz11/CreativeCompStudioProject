using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteClick : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private FMOD.Studio.EventInstance instance;
    
    public FMODUnity.EventReference fmodEvent;
    public Sprite unclicked;
    public Sprite clicked;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/Piano Roll");
        instance.start();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            //Debug.Log(hit.collider.tag);
            if (Physics.Raycast(ray, out hit)) {
                ChangeSprite(hit.transform.gameObject);
                //DontDestroyOnLoad(hit.transform.gameObject);
            }
        }
    }

    void ChangeSprite(GameObject obj) {
        SpriteRenderer objSprite = obj.GetComponent<SpriteRenderer>();
        if (obj.GetComponent<customTag>().hasTag("inactive")) {
            objSprite.sprite = clicked;
            obj.GetComponent<customTag>().rename(0, "active");
            Debug.Log(obj.GetComponent<customTag>().getAtIndex(1));
            instance.setParameterByName(obj.GetComponent<customTag>().getAtIndex(1) + " Active", 1);

        }
        else if (obj.GetComponent<customTag>().hasTag("active")) {
            objSprite.sprite = unclicked;
            obj.GetComponent<customTag>().rename(0, "inactive");
            instance.setParameterByName(obj.GetComponent<customTag>().getAtIndex(1) + " Active", 0);
        }
    }
}
