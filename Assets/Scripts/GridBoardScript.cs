using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBoardScript : MonoBehaviour {

	public GameObject tilePrefab;
	private int[,] gridArray = new int[,] { 
		{ 1, 1, 1, 1 },
		{ 1, 1, 1, 1 },
		{ 1, 1, 1, 1 },
	};


	// Use this for initialization
	void Start () {
		for (int i = 0; i < gridArray.GetLength(0); i++) {
			int y = gridArray.GetLength(0) - i - 1;
			for (int j = 0; j < gridArray.GetLength(1); j++) {
				int x = j;
				if (gridArray[i, j] == 1) {
					var bt = Instantiate(tilePrefab, new Vector2(x, y), Quaternion.identity, this.transform);
					var btScript = bt.GetComponent< BoardTileScript >();
					btScript.xPos = x; btScript.yPos = y;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
