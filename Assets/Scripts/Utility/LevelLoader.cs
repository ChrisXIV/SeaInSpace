using UnityEngine;
using System.Collections;
using System.IO;

// Format: X,Y,Direction,Type,Owner(0 for neutral)

public class LevelLoader : MonoBehaviour {


	//StreamReader reader = new StreamReader(

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(int level)
	{
		TextAsset levelData = (TextAsset)Resources.Load("level"+level);
		StringReader reader = new StringReader(levelData.text);

		if (reader == null)
		{
			Debug.Log("File level"+level+" not readable");
		}
		else
		{
			//First line consists of the X and Y values for the map size
			string tmp = reader.ReadLine();
			string[] elements = tmp.Split(',');
			Map map = GameManager.instance.CreateLevel(int.Parse(elements[0]),int.Parse (elements[1]));

			Debug.Log (map);

			//read in any objects on the level and instantiate them
			while ((tmp = reader.ReadLine()) != null )
			{
				elements = tmp.Split(',');
				//TODO instantiate
			}
		}
	}
}
