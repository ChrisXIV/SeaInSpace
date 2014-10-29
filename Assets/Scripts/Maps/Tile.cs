using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public ObjectsOnTile objectsOnTile {get; private set;}

	// Use this for initialization
	void Start () {
		objectsOnTile = new ObjectsOnTile();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool IsMovePossible(Ship movingShip)
	{
		return objectsOnTile.IsMovePossible(movingShip);
	}
}
