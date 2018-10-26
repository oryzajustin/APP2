using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public GameObject gameOverPanel;
	public Text gameOverText;
	public ScoreManager scoreManager;

	void Awake()
	{
		gameOverPanel.SetActive(false);
	}
	public void GameOverPrompt(){
		gameOverText = GetComponent<Text>();
		scoreManager.GetComponent<ScoreManager>();
		if (scoreManager.playerScore > scoreManager.aiScore) {
			GameObject enable = GameObject.FindGameObjectWithTag ("Finish");
			enable.SetActive (true);
			gameOverText.text = "Congratulations, you won with " + scoreManager.playerScore + " tags!";
		} else {
			GameObject enable = GameObject.FindGameObjectWithTag ("Finish");
			enable.SetActive(true);
			gameOverText.text = "Try again, the AI won with " + scoreManager.aiScore + " tags!";
		}
	}
}
