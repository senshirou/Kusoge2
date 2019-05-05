using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {

	float time;

	float movex = 0.05f;
	

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		

		time += Time.deltaTime;

		

		transform.Translate(movex,0,0);

		if(time >= 2.0f)
		{
			movex = -0.05f;
			
		}

		if(time >= 4.0f)
		{
			movex = 0.05f;
			time = 0;
		}

		

		
		
	}
}
