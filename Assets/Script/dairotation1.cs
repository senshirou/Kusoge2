using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dairotation1 : MonoBehaviour {
	
	float x;
	float z;
	float speed = 0.05f;
	

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//UpArrow（前に傾ける）
		if(Input.GetKey(KeyCode.UpArrow))
		{
			x += speed * Time.deltaTime;
		}

		//DownArrow（後に傾ける）
		if(Input.GetKey(KeyCode.DownArrow))
		{
			x -= speed *　Time.deltaTime;
		}

		//LeftArrow(左に傾ける)
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			z += speed * Time.deltaTime;
		}

		//RightArrow(右に傾ける)
		if(Input.GetKey(KeyCode.RightArrow))
		{
			z -= speed * Time.deltaTime;
		}

		transform.rotation = new Quaternion(x,0,z,1);

	}

	public void stop()
	{
		//dairotation1のスクリプトを停止。
		GetComponent<dairotation1>().enabled = false;
		
	}
}
