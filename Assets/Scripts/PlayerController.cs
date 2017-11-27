using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	public Text interactText;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		SetInteractText ();
		interactText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
	/*
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Study")) {
			SetInteractText ();	
		}
	}
	*/
	void OnMouseDown(){

		SetInteractText ();
	}
	void SetInteractText ()
	{
		
		interactText.text = "You are a college student named Paulo. Hug people and see what happens!";
	}
}

