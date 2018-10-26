using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public float range = 100f;

	float timer;
	float timeToShoot = 5f;
//	Ray shootRay = new Ray();                       
	RaycastHit shootHit;                            
	int shootableMask;                                                 
//	LineRenderer gunLine;           
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

		muzzle = GameObject.FindGameObjectWithTag ("Muzzle");

		gunshot = GetComponent<AudioSource> ();
//		print(player_it);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.time;
		if(Input.GetButtonDown ("Fire1") && playerscript.it && timer >= timeToShoot && Time.timeScale != 0){
//			timeToShoot = Time.time + 1f / fireRate;
			Fire();
		}
	}

	void Fire(){
		timer = 0f;
		muzzleParticle.Play();
		gunshot.Play ();

//		if(Physics.Raycast(player.transform.position, player.transform.forward, out shootHit, range, shootableMask))
		if(Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out shootHit, range, shootableMask))
		{
			if (!(shootHit.collider.tag == "Obstacles")){// && !shootHit.transform.CompareTag(player.tag)) {
				SwapIt ();

				Debug.Log (shootHit.transform.name);
				GameObject impactToDestroy = Instantiate (impact, shootHit.point, Quaternion.LookRotation (shootHit.normal));
				Destroy (impactToDestroy, 4f);
			}
		}
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
