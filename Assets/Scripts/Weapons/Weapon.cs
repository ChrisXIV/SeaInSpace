using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public int shieldDamage {get; private set;}
	public int hullDamage {get; private set;}
	public int range {get; private set;}
	public int rechargeTime {get; private set;}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void Fire(Position position) {}
}
