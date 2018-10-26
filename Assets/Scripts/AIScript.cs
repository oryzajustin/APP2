using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {
	private Transform player;
//	float aiSpeed;
	private Animator anim;
	private UnityEngine.AI.NavMeshAgent nav;   
	public bool it;
	[SerializeField]
	private Transform[] navPoints;
	public ScoreManager score;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> ();
		it = false;
	}
	
	// Update is called once per frame
	void Update () {
//		aiSpeed = 1;
		if (it) {
//			print ("AI IS IT");
			if (score.timeLeft > 0) {
				Chase ();
			} else {
				anim.SetFloat ("speed", 0);
			}

		} else {
//			print ("AI IS NOT IT");
//			if (score.timeLeft > 0){
				RunAway ();
//			}
		}
	}
	void RunAway(){
		float furthestDistance = 0;
		Vector3 runPosition = Vector3.zero;
		foreach (Transform point in navPoints)
		{
			float currentCheckDistance = Vector3.Distance(player.position, point.position);
			if (currentCheckDistance > furthestDistance)
			{
				furthestDistance = currentCheckDistance;
				runPosition = point.position;
			}
		}
		//Set the right destination for the furthest spot
		if (transform.position.z == runPosition.z) {
//			print ("should stop");
			nav.angularSpeed = 150;
			nav.speed = 0;
			anim.SetFloat ("speed", nav.speed);
		} else {
			nav.angularSpeed = 150;
			nav.speed = 6;
//			print ("Running");
			anim.SetFloat ("speed", nav.speed);
			nav.SetDestination (runPosition);
		}
	}
	void Chase(){
		nav.angularSpeed = 150;
		nav.speed = 6;
		nav.acceleration = 10;
		anim.SetFloat ("speed", nav.speed);
		nav.SetDestination (player.position);
	}
}
