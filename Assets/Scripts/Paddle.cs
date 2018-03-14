using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public Ball ball;
	
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () { 
		if(autoPlay){
			AutoPlay();
		} else{
			MoveWithMouse();
		}
	}
	
	void AutoPlay(){
		float ballPosInBlocks = ball.transform.position.x; /// Screen.width * 16; //Fiindca am 16 GameSpaceuri
		print(ballPosInBlocks);
		Vector3 vector3 = new Vector3(Mathf.Clamp(ballPosInBlocks,0.5f,15.5f),this.transform.position.y,this.transform.position.z);
		this.gameObject.transform.position = vector3;
	}
	
	void MoveWithMouse(){
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; //Fiindca am 16 GameSpaceuri
		//print (mousePosInBlocks);
		
		Vector3 vector3 = new Vector3(Mathf.Clamp(mousePosInBlocks,0.5f,15.5f),this.transform.position.y,this.transform.position.z);
		this.gameObject.transform.position = vector3;
	}
}
