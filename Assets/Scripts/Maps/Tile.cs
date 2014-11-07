using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameObject TilePrefab;

	public Vector3 gridPosition;

	public Color unselectedFaceColor = new Color(0f,0f,0f,0f);
	public Color unselectedOutlineColor = new Color(0.22f,1f,1f,1f);

	public Color selectedFaceColor = new Color(0f,0f,0f,0f);
	public Color selectedOutlineColor = new Color(0.22f,1f,0.48f,1f);


	public ObjectsOnTile objectsOnTile {get; private set;}


	// Use this for initialization
	void Start () {
		objectsOnTile = new ObjectsOnTile();
		gridPosition = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool IsMovePossible(Ship movingShip)
	{
		return objectsOnTile.IsMovePossible(movingShip);
	}
	
}
