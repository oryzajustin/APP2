using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class LeaderboardScript : MonoBehaviour {

	protected FileInfo file = null;
	protected StreamReader reader = null;
	protected string text = " "; // assigned to allow first line to be read below
	private TextMeshProUGUI UItext;

	void Start () {
		file = new FileInfo ("./Assets/Scripts/scorefile.txt");
		reader = file.OpenText();
		UItext = GetComponent<TextMeshProUGUI> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (text != null) {
			text = reader.ReadLine();
			UItext.text = UItext.text + text + "\n";
		}
	}
}
