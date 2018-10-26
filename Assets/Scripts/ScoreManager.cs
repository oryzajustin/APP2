using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public int playerScore;
	public int aiScore;
	public float timeLeft;

	private GameObject gameover;
	private GameObject esc;
//	private Text overText;

//	public GameOver script;

//	private Text endText;
	// Use this for initialization
	void Start () {
		playerScore = 0;
		aiScore = 0;
//		script = GetComponent<GameOver> ();
//		gameover = GameObject.FindGameObjectWithTag("Finish");
//		esc = GameObject.FindGameObjectWithTag ("ESC");
//		overText = GetComponentInChildren<Text> ();
//		gameovertext = gameovercanvas.GetComponent<Text> ();
//		gameover.SetActive (false);
//		esc.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
//		gameover.SetActive (false);
//		esc.SetActive (false);
		timeLeft -= Time.deltaTime;
//		if(Input.GetButtonDown("Cancel")){
//			esc.SetActive (true);
//		}
//		if (timeLeft <= 0) 
//		{
//			gameover.SetActive (true);
//			if (playerScore > aiScore) {
////				Text overText = gameovercanvas.GetComponent<Text> ();
//				overText.text = "Congrats, you won with "; // + playerScore + " tags!";
//			} else {
////				Text overText = gameovercanvas.GetComponent<Text> ();
//				overText.text = "Try again, AI won with "; //+ aiScore + " tags!";
//			}
//			BackToMain ();
//		}
	}
//	void GameOver()
//	{
//		endText = GetComponent<Text>();
//		if (playerScore > aiScore) {
//			GameObject enable = GameObject.FindGameObjectWithTag ("Finish");
//			enable.SetActive (true);
//			endText.text = "Congratulations, you won with " + playerScore + " tags!";
//		} else {
//			GameObject enable = GameObject.FindGameObjectWithTag ("Finish");
//			enable.SetActive(true);
//			endText.text = "Try again, the AI won with " + aiScore + " tags!";
//		}
//	}
	public void BackToMain(){
		SceneManager.LoadScene ("StartMenu");
	}
}
