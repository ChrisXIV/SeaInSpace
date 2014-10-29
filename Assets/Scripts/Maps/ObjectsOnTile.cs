using UnityEngine;
using System.Collections;

public class ObjectsOnTile : MonoBehaviour {

	public Ship ship {get; set;}
	public Debris debris {get; set;}

	// Use this for initialization
	void Start () {
		
	}

	//Check for every possible type of object
	public bool IsTileEmpty()
	{
		if(ship == null && debris == null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	//Check for ship only
	public bool IsShipOnTile()
	{
		if(ship != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public bool IsMovePossible(Ship movingShip)
	{
		if(IsTileEmpty())
		{
			return true;
		}
		if(IsShipOnTile())
		{
			return false;
		}
		if(debris != null)
		{
			if(movingShip.stackWithSpaceObjects)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		return false;
	}
}
