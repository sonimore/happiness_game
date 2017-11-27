using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour {

	public float initialStatValue = 50;
	public float statChangeInterval = 0.5f;

	static public float Stress;
	static private float stress {get { return Stress; } set { Stress = value; } }
	static public float Happiness;
	static private float happiness { get { return Happiness; } set { Happiness = value; } }


	// Use this for initialization
	void Start () {
		Stress = initialStatValue;
		Happiness = initialStatValue;
	}
	
	// Update is called once per frame
	void Update () {
		increaseStress (statChangeInterval);
		decreaseHappiness (statChangeInterval);
	}

	void increaseStress(float value) {
		// increases the Stress stat by the inputed value
		Stress += value;
	}

	void decreaseStress(float value) {
		Stress -= value;
	}

	void increaseHappiness(float value) {
		// increases Happiness by the inputed value
		Happiness += value;
	}

	void decreaseHappiness(float value) {
		Happiness -= value;
	}

}
