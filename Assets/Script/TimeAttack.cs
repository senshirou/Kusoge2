using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeAttack : MonoBehaviour {

	Text TAttacktx;
	float time;

	PlayerStopper player;

	// Use this for initialization
	void Start () {

		TAttacktx = GetComponent<Text>();
		var pobj = GameObject.Find("SpherePlayer");
		player = pobj.GetComponent<PlayerStopper>();
		
		
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		if(player.point == 0)
		{
			time -= Time.deltaTime;
		}
		TAttacktx.text = "Time : "+ time.ToString("F1");

		
		

		

		
		
	}

	
}
