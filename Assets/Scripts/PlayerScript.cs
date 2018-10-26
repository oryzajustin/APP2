using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private Rigidbody player;
	private Animator anim;
	private float speed;
	private float rotationSpeed;
//	private ScoreManager playerScore;
//	private Quaternion direction;
	private float movespeed;

	public bool it;

	void Start () {
		player = GetComponent<Rigidbody> ();	
		anim = GetComponent<Animator> ();
		it = true;
//		rotationSpeed = 150;
//		direction = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

		if (movement != Vector3.zero) {
			speed = 5;
//			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (movement), 0.15F);
			transform.rotation = Quaternion.LookRotation(movement);
			transform.Translate (movement * speed * Time.deltaTime, Space.World);
			anim.SetFloat ("speed", speed);
		} else {
			speed = 0;
			anim.SetFloat ("speed", speed);
		}
		//		transform.rotation = Quaternion.LookRotation(movement);
//		direction = Quaternion.LookRotation (movement);
//		movespeed = movement * speed * Time.deltaTime;


	}
}
