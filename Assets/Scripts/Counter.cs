using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	public Text timerText; 
	public float currentTime=0f;
	public float startTime=120f;

	// Use this for initialization
	void Start () {
		currentTime = startTime;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime -= 1 * Time.deltaTime;
		timerText.text = currentTime.ToString("0");

		if (currentTime <= 0) {
			currentTime = 0;
			timerText.color = Color.red;
			SceneManager.LoadScene("LoseMenu");
		}
	}
}
