using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {
	public int X;
	public int Y;
	public Direction direction;

	public Position() {}

	public Position(int X, int Y, Direction direction)
	{
		this.X = X;
		this.Y = Y;
		this.direction = direction;
	}

	public Position clone()
	{
		return new Position(X, Y, direction);
	}
}
