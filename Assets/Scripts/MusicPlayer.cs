using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
	
	public static MusicPlayer musicPlayer;

	void Awake(){
		if (MusicPlayer.musicPlayer == null) {
			MusicPlayer.musicPlayer = this;
			GameObject.DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);	 
		}
	}

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
