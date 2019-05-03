using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dairotation : MonoBehaviour {
	
	float x;
	float z;
	float speed = 0.5f;

	// Use this for initialization
	void Start () {

	

		
		
	}
	
	// Update is called once per frame
	void Update () {

		//UpArrow
		if(Input.GetKey(KeyCode.UpArrow))
		{
			x = speed;
		}

		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			x = 0;
		}

		//DownArrow
		if(Input.GetKey(KeyCode.DownArrow))
		{
			x = -speed;
		}

		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			x = 0;
		}

		//LeftArrow
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			z = speed;
		}

		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			z = 0;
		}

		//RightArrow
		if(Input.GetKey(KeyCode.RightArrow))
		{
			z = -speed;
		}

		if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			z = 0;
		}



		

		

		

		transform.Rotate(x,0,z);


		
	}
}
