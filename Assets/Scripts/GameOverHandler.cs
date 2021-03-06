﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour {
	public GameObject gameover;
	private GameObject esc;	
	private ScoreManager score;
//	public float timeLeft;

	private bool paused;
	// Use this for initialization
	void Start () {
//		gameover = GameObject.FindGameObjectWithTag("Finish");
		esc = GameObject.FindGameObjectWithTag ("ESC");
		score = GetComponent<ScoreManager> ();

		gameover.SetActive (false);
		esc.SetActive (false);
		paused = false;

	}
	
	// Update is called once per frame
	void Update () {
//		timeLeft -= Time.deltaTime;
		if(Input.GetButtonDown("Cancel") && !paused){
			esc.SetActive (true);
			paused = true;
		}
		else if(Input.GetButtonDown("Cancel") && paused){
			esc.SetActive (false);
			paused = false;
		}
		if (score.timeLeft <= 0 && !paused) {
			gameover.SetActive (true);
//			DisplayScore ();
		}
		else if (score.timeLeft <= 0 && paused) {
			gameover.SetActive (true);
			esc.SetActive (false);
		}
	}
}
