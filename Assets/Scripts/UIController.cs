using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UIController : MonoBehaviour {

	private Text Text;
	private string displayHappiness;
	private string displayStress;

	// Use this for initialization
	void Start () {
		Text = GetComponent<Text> ();

		// should initialize the text's position and anchors in code if possible
		// to guarentee consistency across scenes
	}
	
	// Update is called once per frame
	void Update () {
		// set display values that don't include decimal points
		displayHappiness = StatsController.Happiness.ToString ("F0");
		displayStress = StatsController.Stress.ToString ("F0");
		Text.text = "Happiness: " + displayHappiness + "\n" + "Stress: " + displayStress;
	}
}
