using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Ship selectedShip;
	public Map map;

	void Awake() 
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		LevelLoader loader = new LevelLoader();
		loader.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SelectShip(Ship ship)
	{
		//TODO deselect previous selected
		selectedShip = ship;
		// TODO GUI, change color
	}

	public void CreateLevel(int X, int Y)
	{ /*
		map = new List<List<Tile>> ();
		for (int i=0; i<X; i++) {
			List<Tile> row = new List<Tile> ();
			for (int j=0; j<Y; j++) {
				Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (i, 0, j), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> (); 
				tile.gridPosition = new Vector3 (i, 0, j);
				row.Add (tile);
			}
			map.Add (row);
		}
		*/
	}
}
