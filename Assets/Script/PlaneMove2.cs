using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove2 : MonoBehaviour {

	float time;

	float movez = -0.05f;
	

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		

		time += Time.deltaTime;

		

		transform.Translate(0,0,movez);

		if(time >= 2.0f)
		{
			movez = 0.05f;
			
		}

		if(time >= 4.0f)
		{
			movez = -0.05f;
			time = 0;
		}

		

		
		
	}
}
