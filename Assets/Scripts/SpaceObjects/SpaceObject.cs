using UnityEngine;
using System.Collections;

public class SpaceObject : MonoBehaviour {

	public Position position {get; private set;}

	public SpaceObject() {}

	public SpaceObject(Position position)
	{
		this.position = position;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
