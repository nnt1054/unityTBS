using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTileScript : MonoBehaviour {

	public int xPos = 0;
	public int yPos = 0;

	//Get the GameObject’s mesh renderer to access the GameObject’s material and color
    SpriteRenderer spriteRenderer;
    BoxCollider2D tileCollider;

    Color defaultColor = new Color32(90, 155, 115, 255);
    Color hoverColor = new Color32(80, 125, 100, 255);

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		tileCollider = GetComponent<BoxCollider2D>();

		spriteRenderer.color = defaultColor;
		Vector2 S = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        tileCollider.size = S;
	}
	
	// Update is called once per frame
	void Update () {	
	}

    void OnMouseEnter()
    {
        spriteRenderer.color = hoverColor;
    }

    void OnMouseExit()
    {
		spriteRenderer.color = defaultColor;
    }

    void OnMouseUpAsButton() {
    	// Debug.Log(i.ToString() + ", " + j.ToString());
    	Debug.Log(xPos.ToString() + ", " + yPos.ToString());
    }
}
