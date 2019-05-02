using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	public AudioSource Steps;
	public float speed= 60.0f;
	private Transform PlayerTransform;
	private Rigidbody _rigidbody;
	public bool grounded;
	public int Points=0;
	public AudioSource Collect;
	Animator Anima;


	private bool walking = false;


	// Use this for initialization
	void Start () {
		PlayerTransform = GetComponent<Transform> ();
		_rigidbody = GetComponent<Rigidbody> ();
		_rigidbody.useGravity = false;
		_rigidbody.freezeRotation = true;
		Anima = GetComponent<Animator>();
		Anima.Play ("Idle");
	}

	//Update is called once per frame
	//void Update()
//	{
	//	transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,speed * Input.GetAxis("Vertical") * Time.deltaTime);
	//	Anima.Play ("Walking");
	//  if (Input.GetKeyDown (Forward)) 
	//	{
	//		transform.position += transform.forward * Time.deltaTime * speed;
	//		PlayerTransform.position = new Vector3(PlayerTransform.position.x,PlayerTransform.position.y,Input.GetAxis("Horizontal")*Time.deltaTime);
	//		Anima.Play ("Walking");
	//	}

	//}
	void FixedUpdate () {
		PlayerTransform.Rotate(0,Input.GetAxis("Horizontal")*((speed/4)/2) ,0);
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis ("Vertical") * Time.deltaTime * speed);

		if (walking == false) {
			Anima.Play ("Idle");
		}
		movement ();
	}

	void movement(){
		if (Input.GetKey (KeyCode.W)) {
			walking = true;
			Anima.Play ("Walking");
			Steps.Play ();
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			Anima.Play ("Idle");
		}
	}
	void OnCollissionStay()
	{
		grounded = true;

	}
	void OnTriggerEnter(Collider Buddy)
	{
		if (Buddy.tag == "Coin") {
			Collect.Play();
			CollectCoins.points += 1;
			Points ++;
			Destroy (Buddy.gameObject);
		}
		if (Buddy.tag == "Finish") {
			SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
		}
		if (Buddy.tag == "Trap") {
			SceneManager.LoadScene("LoseMenu");
		}
	}
}