using System;

public class SmallLaser : Weapon
{
		public override void Fire (Position position)
		{
				//TODO 
				switch (position.direction) {
				case(Direction.UP): 
						for (int i=1; i < this.range; i++) {
								if (position.Y + i > GameManager.instance.map.mapSizeY-1) {
										break;
								}

								if (!GameManager.instance.map.map [position.X] [position.Y + i].objectsOnTile.IsTileEmpty ()) {
										//TODO Check what is on the tile
										break;
								}
						}
						break;
				case(Direction.DOWN):
						for (int i=1; i < this.range; i++) {
								if (position.Y - i < 0) {
										break;
								}
				
								if (!GameManager.instance.map.map [position.X] [position.Y - i].objectsOnTile.IsTileEmpty ()) {
										//TODO Check what is on the tile
										break;
								}
						}
						break;
				case(Direction.LEFT):
						for (int i=1; i < this.range; i++) {
								if (position.X - i < 0) {
										break;
								}
				
								if (!GameManager.instance.map.map [position.X-i] [position.Y].objectsOnTile.IsTileEmpty ()) {
										//TODO Check what is on the tile
										break;
								}
						}
						break;
				case(Direction.RIGHT):
						for (int i=1; i < this.range; i++) {
								if (position.X + i > GameManager.instance.map.mapSizeX-1) {
										break;
								}
				
								if (!GameManager.instance.map.map [position.X + i] [position.Y].objectsOnTile.IsTileEmpty ()) {
										//TODO Check what is on the tile
										break;
								}
						}
						break;
				}
		}
}


