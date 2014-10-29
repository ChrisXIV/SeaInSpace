using UnityEngine;
using System.Collections;

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
}
