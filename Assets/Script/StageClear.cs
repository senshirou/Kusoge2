﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StageClear : MonoBehaviour {

	Text ClearText;

	// Use this for initialization
	void Start () {

		

		ClearText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

		

		
		
	}

	public void Stagetrue()
	{
		ClearText.enabled = true;
	}

	
}
