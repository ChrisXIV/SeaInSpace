using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

	public int mapSizeX;
	public int mapSizeY;
	public List<List<Tile>> map {get; private set;}

	// Use this for initialization
	void Start () {
		map = new List<List<Tile>>();
		for (int i = 0; i < mapSizeX ; i++)
		{
			for (int j = 0; j < mapSizeY ; j++)
			{
				map[i][j] = new Tile();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
