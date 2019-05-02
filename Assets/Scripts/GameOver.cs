using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

//	public Texture texture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void quit(){
		Application.Quit ();
	}
	public void toMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
//	void onGUI()
//	{
//		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), texture);
//		GUI.Box (new Rect (Screen.width / 2 - 70, Screen.height - 205, 140, 110), "");
//		GUI.Box (new Rect (Screen.width / 2 - 65, Screen.height - 200, 130, 100), "GAME OVER");

//		if (GUI.Button(new Rect(Screen.width/2-80,Screen.height-80,160,60),	"Play Again?")){
//				Application.loadLevel(0);
//			}
//	}
}
