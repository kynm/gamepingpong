using UnityEngine;
using System.Collections;

public class ballMotion : MonoBehaviour {
	public float speedX=0;
	public float speedY=0;

	public AudioClip[] audio;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		GoBall ();
	}
	/* Hàm này để nhận biết quả bóng chạm vào 1 collider, sẽ chỉ chạy 1 lần khi va chạm, nó khác với hàm OnCollisionStay2D
khi va chạm, có nhiều sự phân biệt giữa vật thể tĩnh và vật thể có thể chuyển động sau khi va chạm
	 */
	 void OnCollisionEnter2D (Collision2D colliWith) {
		if (colliWith.collider.tag == "Player") {
			Debug.Log ("collision");        
			AudioSource.PlayClipAtPoint (audio [0], Camera.main.transform.position);
			float vy = rigidbody2D.velocity.y;
			float vx = rigidbody2D.velocity.x;
			if (Mathf.Abs (vx) > 15)
			vx = 15 * Mathf.Sign (vx);
			else if (Mathf.Abs (vx) < 5)
			vx = 5 * Mathf.Sign (vx);

			if (Mathf.Abs (vy) > 7)
			vy = 7 * Mathf.Sign (vy);
			else if (Mathf.Abs (vy) < 3)
			vy = 3 * Mathf.Sign (vy);

			rigidbody2D.velocity = new Vector2 (vx, vy);
		} 
	 }
	 void GoBall(){
		float randomNumber = Random.Range (0f, 1f);
		if (randomNumber > 0.5f) {
			Debug.Log("turn right");
			//rigidbody2D.AddForce (new Vector2(50,20));
			rigidbody2D.velocity=new Vector2(speedX,speedY);
			} else {
				Debug.Log("turn left");
				rigidbody2D.velocity=new Vector2(-speedX,-speedY);
			//rigidbody2D.AddForce (new Vector2(-50,-20));
		}
	}
	IEnumerator ResetBall(){
		rigidbody2D.velocity = new Vector2 (0,0);
		transform.localPosition = new Vector3 (0,0,transform.position.z);

		yield return new WaitForSeconds(1);
		GoBall ();
	}
}
