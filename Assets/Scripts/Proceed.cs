using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proceed : MonoBehaviour {

	public void goToLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
