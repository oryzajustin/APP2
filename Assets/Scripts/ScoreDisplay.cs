using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	public ScoreManager score_p;
	public ScoreManager score_a;
	private Text scoretext;
	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "Player score: " + score_p.playerScore + "\n" + "AI score: " + score_a.aiScore;
	}
}
