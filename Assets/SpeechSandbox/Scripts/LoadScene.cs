using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public string levelOneToLoad;
	public string levelTwoToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetDown (OVRInput.Button.SecondaryIndexTrigger)) 
		{
			//Load Male Scene
			Debug.Log("Loading male scene");
			SceneManager.LoadScene ("levelOneToLoad");
		}
		else if  (OVRInput.GetDown (OVRInput.Button.PrimaryIndexTrigger)) 
		{
			//Load Female Scene
			Debug.Log("Loading Female scene");
			SceneManager.LoadScene ("levelTwoToLoad");
		}
		
	}
}
