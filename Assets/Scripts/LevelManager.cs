using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level){
		Debug.Log ("Level load requested");
		Application.LoadLevel (level);
	}

	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void QuitRequest(){
		Debug.Log ("Quit request");
		Application.Quit ();
	}
	
	public void BrickDistroyed(){
		if(Brick.breakableCount <= 0){
			LoadNextLevel();
		}
	}	
}
