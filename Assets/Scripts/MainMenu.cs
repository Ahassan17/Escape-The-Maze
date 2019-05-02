using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	//public Texture texture; 
	//public string howToPlay = "Control character by AD keys only\nAs charachter will continue in walking except it find a wall in front of it\nCollect Coins to increase your score";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startG(){
		SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
	}
	//void OnGUI() 
	//{ 
		//GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texture); 
		//GUI.Box (new Rect (Screen.width / 2 - 120, Screen.height - 210, 240, 110), "Instructions:");
		//GUI.Box(new Rect (Screen.width -720, Screen.height - 190, 500, 500), howToPlay);
		//if (GUI.Button (new Rect (Screen.width / 2 - 80, Screen.height - 80, 160, 60), "Press to play")) 
		//{ 
		//	Application.LoadLevel (1); 
		//} 
}

