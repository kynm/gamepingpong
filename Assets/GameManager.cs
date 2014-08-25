using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static int Score1 = 0;
	public static int Score2 = 0;
	public GUISkin skin;

	public static void addScore (string wall)
	{
		if (wall == "leftWall") {
			Score1++;
			} else if (wall == "rightWall") {
				Score2++;       
			}
		Debug.Log ("player 1 :" + Score1);
		Debug.Log ("player 2 :" + Score2);

	}

	void OnGUI ()
		{
			GUI.skin = skin;
			GUI.Label (new Rect (Screen.width / 2 - 50, 10, 100, 100), "" + Score1);
			GUI.Label (new Rect (Screen.width / 2 + 50, 10, 100, 100), "" + Score2);

		}
}
