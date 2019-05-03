using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStopper : MonoBehaviour {

	Rigidbody rig;
	dairotation1 dia1;

	TimeAttack TAtext;

	public float point = 1;

	
	




	// Use this for initialization
	void Start () {

		//Tag PlaneのGameObjectにdairotationスクリプトをコンポーネント
		var dia = GameObject.FindGameObjectWithTag("Plane");
		dia1 = dia.GetComponent<dairotation1>();
		
		var Taobj = GameObject.Find("TimeAttack");
		TAtext = Taobj.GetComponent<TimeAttack>();
		rig = GetComponent<Rigidbody>();
		

		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y <= -50)
		{
			SceneManager.LoadScene("GamePlay");

		}

		
		
	}

	void OnCollisionEnter (Collision sphere)
	{
		//名前PlayerStopperのゲームオブジェクトに接触した時の動作。
		if(sphere.gameObject.name == "Goal")
		{
			//isKinematicをオフ
			rig.isKinematic = true;
			//diarotation 1のstop()を動かしてrotation入力禁止。
			dia1.stop();

			point = 0;
			
			
			
		}

	}
}
