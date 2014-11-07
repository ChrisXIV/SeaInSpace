using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	
	public static GameManager instance;
	public Ship selectedShip;
	public Map map;
	public GameObject TilePrefab;

	public LevelLoader loader;

	void Awake() 
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		loader = gameObject.AddComponent<LevelLoader>();
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

	public Map CreateLevel(int X, int Y)
	{ 
		map = gameObject.AddComponent<Map>();
		map.mapSizeX = X;
		map.mapSizeY = Y;
		map.TilePrefab = TilePrefab;
		//map = new Map(X, Y, TilePrefab);
		return map;
	}
}
