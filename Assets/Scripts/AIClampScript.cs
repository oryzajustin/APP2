using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIClampScript : MonoBehaviour {
	public Text indicator;
//	PlayerScript playerscript;
	AIScript aiscript;
	Vector3 indicatorPos;

	// Use this for initialization
	void Start () {
//		playerscript = GetComponent<PlayerScript> ();
		aiscript = GetComponent<AIScript> ();
	}

	// Update is called once per frame
	void Update () {
		if (aiscript.it) {
			indicator.text = "AI is IT!";
			indicatorPos = Camera.main.WorldToScreenPoint (GameObject.FindGameObjectWithTag ("AIClamp").transform.position);
			indicator.transform.position = indicatorPos;
		} 
	}
}
