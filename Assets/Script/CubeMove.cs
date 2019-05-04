using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

	float time;

	float movex = 0.1f;
	

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		

		time += Time.deltaTime;

		

		transform.Translate(movex,0,0);

		if(time >= 1.6f)
		{
			movex = -0.1f;
			
		}

		if(time >= 3.2f)
		{
			movex = 0.1f;
			time = 0;
		}

		

		
		
	}
}
