using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;
	public static int breakableCount = 0;
	public Sprite[] hitSprites;
	
	private int timesHits;
	private LevelManager levelManager;
	private bool isBreakable;
	
	// Use this for initialization
	void Start () {
		timesHits = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		isBreakable = (this.tag == "Breakable");
		
		if(isBreakable){
			Brick.breakableCount++;
			print(breakableCount);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		AudioSource.PlayClipAtPoint(crack,transform.position,0.2f);
		if(isBreakable){
			HandleHits();
		}
	}
	
	void HandleHits(){
		int maxHits = hitSprites.Length + 1;
		timesHits++;
		if(timesHits >= maxHits){
			Brick.breakableCount--;
			Destroy(gameObject);
			levelManager.BrickDistroyed();
			return;
		}
		
		LoadSprites();
	}
	
	void LoadSprites(){
		int spriteIndex = timesHits - 1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
