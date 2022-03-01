using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounds : MonoBehaviour
{
	public enum Bounds { 
		TOP, BOTTOM
	};
	public Bounds side;
	private BoxCollider2D collide;
    private float space = 0.9f;

	void Start () {
		Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
		collide = GetComponent<BoxCollider2D>();

		if(side == Bounds.TOP){
            collide.size = new Vector2(Mathf.Abs(left.x) + Mathf.Abs(right.x), space);
            collide.offset = new Vector2(0, space/2);
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth/2, Camera.main.pixelHeight, 1));
		}	
		if(side == Bounds.BOTTOM){
            collide.size = new Vector2(Mathf.Abs(left.x) + Mathf.Abs(right.x), space);
            collide.offset = new Vector2(0, -space/2);
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth/2, 0, 1));
		}
	}
}
