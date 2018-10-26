using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditTextScript : MonoBehaviour {
	private Text gameovertext;
	public ScoreManager score_p;
	public ScoreManager score_a;

	// Use this for initialization
	void Start () {
		gameovertext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		DisplayScore ();
	}
	void DisplayScore(){
		if (score_p.playerScore > score_a.aiScore) {
			gameovertext.text = "Congrats! You won with " + score_p.playerScore + " tags!";
		} else if (score_p.playerScore == score_a.aiScore && (score_p.playerScore != 0 || score_a.aiScore != 0)) {
			gameovertext.text = "Sorry! AI won with " + score_a.aiScore + " tags!";
		} else if(score_p.playerScore == 0 && score_a.aiScore == 0) {
			gameovertext.text = "No one got tagged, it's a DRAW!";
		}
	}
}
