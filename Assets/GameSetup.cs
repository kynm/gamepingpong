using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform player1;
	public Transform player2;

	public Camera mCamera;

	// Update is called once per frame
	void Update () {
		/*
UNITY dùng hệ tọa độ có tâm (0,0) nằm giữa màn hình, tọa độ y hướng lên trên, x hướng sang phải. Screen.Width/height sẽ
lấy tọa độ của màn hình người chơi. Hàm screenToWorldPoint chuyển tọa độ đó về tọa độ của unity
		 */
		 topWall.size = new Vector2 (3*mCamera.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x,1f);
		 topWall.center= new Vector2 (0f,mCamera.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y+0.5f);

		/*
mCamera.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)) sẽ lấy tọa độ từ màn hình chuyển về tọa độ game, màn hình chơi hay
screen được thiết kế tọa độ bottom left là (0,0), top right là (screen.width,screen.height)
		 */
		 bottomWall.size = new Vector2 (3*mCamera.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x,1f);
		 bottomWall.center= new Vector2 (0f,mCamera.ScreenToWorldPoint(new Vector3(0f,0f,0f)).y-0.5f);

//      Debug.DrawLine (new Vector3(0,0,0),new Vector3 (1f, 0f, 0f), Color.red);

		/*Chú ý là đây là các collider ko phải là các transform nên chỉ các collider thay đổi kích thước và vị trí
vật thể ko thay đổi kích thước và vị trí
		 */
		 leftWall.size = new Vector2 (1f,3*mCamera.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y);
		 leftWall.center= new Vector2 (mCamera.ScreenToWorldPoint(new Vector3(0f,0f,0f)).x-0.5f,0f);

		 rightWall.size = new Vector2 (1f,3*mCamera.ScreenToWorldPoint(new Vector3(0f,Screen.height,0f)).y);
		 rightWall.center= new Vector2 (mCamera.ScreenToWorldPoint(new Vector3(Screen.width,0f,0f)).x+0.5f,0f);

		 player1.position = new Vector3 (mCamera.ScreenToWorldPoint(new Vector3(70f,0f,0f)).x,player1.position.y,player1.position.z);
		 player2.position = new Vector3 (mCamera.ScreenToWorldPoint(new Vector3(Screen.width-70f,0f,0f)).x,player2.position.y,player2.position.z);

		}
	}
