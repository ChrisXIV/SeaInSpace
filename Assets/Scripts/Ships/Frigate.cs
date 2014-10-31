using UnityEngine;
using System.Collections;

public class Frigate : Ship {

	public Weapon left {get; set;}
	public Weapon right {get; set;}
	
	public Frigate(Weapon left, Weapon right)
	{
		this.left = left;
		this.right = right;
	}
	
	// Use this for initialization
	void Start () {
		stackWithSpaceObjects = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public override void FireWeapons() 
	{
		Position fireLeft = position.clone();
		Position fireRight = position.clone();

		switch(this.position.direction)
		{
		case (Direction.UP):
			fireLeft.direction = Direction.LEFT;
			fireRight.direction = Direction.RIGHT;
			break;
		case(Direction.DOWN):
			fireLeft.direction = Direction.RIGHT;
			fireRight.direction = Direction.LEFT;
			break;
		case (Direction.LEFT):
			fireLeft.direction = Direction.DOWN;
			fireRight.direction = Direction.UP;
			break;
		case(Direction.RIGHT):
			fireLeft.direction = Direction.UP;
			fireRight.direction = Direction.DOWN;
			break;
		}

		left.Fire(this.position);
		right.Fire (this.position);
	}
}