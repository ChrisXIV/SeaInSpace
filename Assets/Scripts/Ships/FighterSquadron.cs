using UnityEngine;
using System.Collections;

public class FighterSquadron : Ship {

	public Weapon frontOne {get; set;}
	public Weapon frontTwo {get; set;}

	public FighterSquadron(Weapon frontOne, Weapon frontTwo)
	{
		this.frontOne = frontOne;
		this.frontTwo = frontTwo;
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
		frontOne.Fire(this.position);
		frontTwo.Fire(this.position);
	}
}
