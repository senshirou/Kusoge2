using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextStage2 : MonoBehaviour {

	Button Next2;
	Text ChildTexts;

    

	// Use this for initialization
	void Start () {

		Next2 = GetComponent<Button>();
		ChildTexts = GetComponentInChildren<Text>();
		ChildTexts.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonTrue()
	{
		Next2.interactable = true;
		ChildTexts.enabled = true;
	    
	}

	public void Stage2()
	{
		SceneManager.LoadScene("STAGE2");
	}
}
