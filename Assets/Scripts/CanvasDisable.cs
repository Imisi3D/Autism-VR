using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDisable : MonoBehaviour {

	//public Text canvasText1;
	public Canvas CanvasObject; // Assign in inspector

	public float timeBeforeCanvasClose = 10f;

	// Use this for initialization
	void Start () {
		Invoke("DisableText", timeBeforeCanvasClose);//invoke after 5 seconds

	}
	
	void DisableText()
	{ 
		//canvasText1.enabled = false; 
		CanvasObject.enabled = !CanvasObject.enabled;
	} 
}
