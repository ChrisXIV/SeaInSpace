using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

	public int mapSizeX;
	public int mapSizeY;
	public List<List<Tile>> map {get; private set;}
	public GameObject TilePrefab;

	// Use this for initialization
	void Start () {
		map = new List<List<Tile>>();
		for (int i=0; i<mapSizeX; i++) {
			List<Tile> row = new List<Tile> ();
			for (int j=0; j<mapSizeY; j++) {
				Tile tile = ((GameObject) Instantiate (TilePrefab, new Vector3 (i, 0, j), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile>(); 
				tile.gridPosition = new Vector3 (i, 0, j);
				row.Add (tile);
			}
			map.Add (row);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
