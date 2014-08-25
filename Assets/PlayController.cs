using UnityEngine;
using System.Collections;

public class PlayController : MonoBehaviour
{
	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 0;

		// Update is called once per frame
		void Update ()
		{
			
			if (Input.GetKey (moveUp)) {
				rigidbody2D.velocity = new Vector2 (0, speed);// if you use javascript you can set for y velocity by rigidbody.velocity.y = speed;
			} else if (Input.GetKey (moveDown)) {
				rigidbody2D.velocity = new Vector2 (0, -speed);
			} else {
				rigidbody2D.velocity = new Vector2 (0, 0);
			}
		}
}
