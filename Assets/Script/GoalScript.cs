using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalScript : MonoBehaviour {

	ParticleSystem goal;
	
	StageClear clear;

	// Use this for initialization
	void Start () {

		var sclear = GameObject.Find("Stage Clear");
		clear = sclear.GetComponent<StageClear>();

		goal = GetComponent<ParticleSystem>();
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision sphere)
	{
		if(sphere.gameObject.name == "SpherePlayer")
		{
			goal.Play();
			clear.Stagetrue();
		}
	}
}
