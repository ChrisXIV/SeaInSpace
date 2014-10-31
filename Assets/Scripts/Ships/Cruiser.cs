using UnityEngine;
using System.Collections;

public class Cruiser : Ship {

	public Weapon front {get; set;}
	
	public Cruiser(Weapon front)
	{
		this.front = front;
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public override void FireWeapons() 
	{
		front.Fire(this.position);
	}

}
