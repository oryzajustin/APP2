using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour {
	public ScoreManager score_p;
	public ScoreManager score_a;
	private Text scoretext;
	private string writeToFile;

	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "Player score: " + score_p.playerScore + "\n" + "AI score: " + score_a.aiScore;
	}
	public void BackToMain(){
		SceneManager.LoadScene ("StartMenu");
		if (score_p.timeLeft >= 0) {
			if (score_a.aiScore == score_p.playerScore) {
				writeToFile = "AI won with: " + score_a.aiScore.ToString () + " points";
				System.IO.File.AppendAllText ("./Assets/Scripts/scorefile.txt", writeToFile + "\n");
			}
			else if (score_p.playerScore > score_a.aiScore) {
				writeToFile = "Player won with: " + score_p.playerScore.ToString () + " points";
				System.IO.File.AppendAllText ("./Assets/Scripts/scorefile.txt", writeToFile + "\n");
			}
		}
	}
}
