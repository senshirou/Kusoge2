﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalScript3 : MonoBehaviour {

	ParticleSystem goal;
	
	StageClear2 clear;

	

	NextStage3 st3;

	// Use this for initialization
	void Start () {

		goal = GetComponent<ParticleSystem>();

		var sclear = GameObject.Find("Stage Clear");
		clear = sclear.GetComponent<StageClear2>();
		var st3gbj = GameObject.Find("Button");
		st3 = st3gbj.GetComponent<NextStage3>();
		

		
		
		
		
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
			st3.ButtonTrue();
			Destroy(gameObject);
			
			
		}

		Destroy(gameObject,1.1f);
	}
}
