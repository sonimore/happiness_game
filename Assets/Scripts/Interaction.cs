using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Interaction : MonoBehaviour {
	public Text interactText;
	RaycastHit hit;
	Ray ray;

	// Use this for initialization
	void Start () {
		interactText.text = "";
	}
	/*
	void OnMouseDown() {
		
		if (Input.GetMouseButtonDown (0) && gameObject.tag == "Desk") {
			Debug.Log ("Pressed left click.");
		}
		else if (Input.GetMouseButtonDown (0) && gameObject.tag == "Gym") {
			Debug.Log ("Pressed left click gym.");
		}

		/*
		if (other.gameObject.CompareTag ("Study")) {
			SetDeskText ();
		} else if (other.gameObject.CompareTag ("Chair")) {
			SetChairText ();
		} else if (other.gameObject.CompareTag ("Gym")) {
			SetGymText ();
		} else if (other.gameObject.CompareTag ("Bed")) {
			SetBedText ();
		}
		if (gameObject == Desk) {
			SetDeskText ();
		}		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();
		Physics.Raycast (ray,out hit);
		/*if (Input.GetMouseButtonDown (0) && hit.collider.tag == "Desk") {
			SetDeskText ();
			Debug.Log ("Pressed left click DESK.");
		} else if (Input.GetMouseButtonDown (0) && hit.collider.tag == "Gym") {
			SetGymText ();
		} else if (Input.GetMouseButtonDown (0) && hit.collider.gameObject.tag == "Bed") {
			SetBedText ();
		} else if (Input.GetMouseButtonDown (0) && hit.collider.gameObject.tag == "Chair") {
			SetChairText ();
		}


		
	}
	
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
				// Whatever you want it to do.
		}
	}*/




	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{

			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				if (hitInfo.transform.gameObject.tag == "Desk")
				{
					Debug.Log ("Desk!");
					SetDeskText ();
				} else if (hitInfo.transform.gameObject.tag == "Bed") {
					Debug.Log ("Bed!");
					SetBedText ();
				} else if (hitInfo.transform.gameObject.tag == "Gym") {
					Debug.Log ("Gym!");
					SetGymText ();
				} else if (hitInfo.transform.gameObject.tag == "Chair") {
					Debug.Log ("Chair!");
					SetChairText ();
				}
			} else {
				Debug.Log("No hit");
			}
		} 
	}
	void SetDeskText (){
		interactText.text = "You studied!";
	}
	void SetChairText(){
		interactText.text = "You sat!";
	}
	void SetGymText(){
		interactText.text = "You exercised!";
	}
	void SetBedText(){
		interactText.text = "You slept!";
	}
}