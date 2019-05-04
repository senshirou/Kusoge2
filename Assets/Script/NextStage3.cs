using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextStage3 : MonoBehaviour {

	Button Next3;
	Text ChildText;

    

	// Use this for initialization
	void Start () {

		Next3 = GetComponent<Button>();
		ChildText = GetComponentInChildren<Text>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonTrue()
	{
		Next3.interactable = true;
		ChildText.enabled = true;
		Debug.Log("catch");
	    
	}

	public void Stage3()
	{
		SceneManager.LoadScene("STAGE3");
	}
}
