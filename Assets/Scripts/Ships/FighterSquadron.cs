﻿using UnityEngine;
using System.Collections;

public class FighterSquadron : Ship {

	public Weapon front {get; set;}

	public FighterSquadron(Weapon front)
	{
		this.front = front;
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
		front.Fire(this.position);
	}
}
