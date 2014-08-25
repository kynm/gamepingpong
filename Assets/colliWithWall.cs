using UnityEngine;
using System.Collections;

public class colliWithWall : MonoBehaviour {
	public AudioClip gameover;
	void OnTriggerEnter2D (Collider2D colliWith){
		Debug.Log ("fd");
		if (colliWith.tag == "ball") {
			string name=transform.name;
			GameManager.addScore(name);
			AudioSource.PlayClipAtPoint (gameover, Camera.main.transform.position);
			colliWith.gameObject.SendMessage("ResetBall");
		}
	}
}
