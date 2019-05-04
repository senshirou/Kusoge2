using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalScript : MonoBehaviour {

	ParticleSystem goal;
	
	StageClear clear;

	NextStage2 st2;

	NextStage3 st3;

	// Use this for initialization
	void Start () {

		goal = GetComponent<ParticleSystem>();

		var sclear = GameObject.Find("Stage Clear");
		clear = sclear.GetComponent<StageClear>();
		var st2gbj = GameObject.Find("NextButton");
		st2 = st2gbj.GetComponent<NextStage2>();
		

		
		
		
		
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
			st2.ButtonTrue();
			
			
		}

		Destroy(gameObject,1.1f);
	}
}
