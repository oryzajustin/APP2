using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShoot : MonoBehaviour {
	public float range = 100f;

	float timer;                                    
                     
	RaycastHit shootHit;                            
	int shootableMask;                                                 
         
	ParticleSystem muzzleParticle;
	GameObject muzzle;

	private ScoreManager score;

	GameObject player;
	GameObject ai;
	public GameObject impact;

	AudioSource gunshot;

	PlayerScript playerscript;
	bool player_it;
	AIScript aiscript;
	bool ai_it;

	// Use this for initialization
	void Start () {
		shootableMask = LayerMask.GetMask ("Shootable");
		player = GameObject.FindGameObjectWithTag ("Player");
		ai = GameObject.FindGameObjectWithTag ("AI");

		playerscript = player.GetComponent<PlayerScript> ();
		player_it = playerscript.it;

		aiscript = ai.GetComponent<AIScript> ();
		ai_it = aiscript.it;

		muzzleParticle = player.GetComponent<ParticleSystem> ();

		score = GetComponent<ScoreManager> ();

		muzzle = GameObject.FindGameObjectWithTag ("AIMuzzle");
		gunshot = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (muzzle.transform.position, muzzle.transform.forward, out shootHit, range, shootableMask)) {
			if (aiscript.it && !(shootHit.collider.tag == "Obstacles")) {
				Fire ();
			}
		}
	}
	void Fire(){
		
		muzzleParticle.Play();
		gunshot.Play ();

		//		if(Physics.Raycast(player.transform.position, player.transform.forward, out shootHit, range, shootableMask))
//		if(Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out shootHit, range, shootableMask))
//		{
		GameObject impactToDestroy = Instantiate (impact, shootHit.point, Quaternion.LookRotation (shootHit.normal));
		SwapIt ();
			
//		Debug.Log(shootHit.transform.name);
		Destroy(impactToDestroy, 4f);
//		}
	}
	void SwapIt(){
		if (!playerscript.it && aiscript.it) {
			playerscript.it = true;
			aiscript.it = false;
//			player_it = true;
//			ai_it = false;
			score.aiScore++;
		} else if(playerscript.it && !aiscript.it) {
			playerscript.it = false;
			aiscript.it = true;
//			player_it = false;
//			ai_it = true;
			score.playerScore++;
		}
	}
}
