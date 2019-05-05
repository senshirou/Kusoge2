using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StageClear2 : MonoBehaviour {

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
		Invoke("Titletoback",5f);
		
		
	}

	public void Titletoback()
	{
		SceneManager.LoadScene("TITLE");

	}

	
	
}
