using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollManager : MonoBehaviour {
	private ScrollRect scrollzone;
	// Use this for initialization
	void Start () {
		scrollzone = GetComponent<ScrollRect> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (scrollzone.verticalNormalizedPosition > 0.5f) {
			scrollzone.verticalNormalizedPosition = 0.5f;
		}
//		else if (scrollzone.verticalNormalizedPosition < 0.0f) {
//			scrollzone.verticalNormalizedPosition = 0.0f;
//		}
	}
}
