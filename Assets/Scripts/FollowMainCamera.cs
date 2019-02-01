using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMainCamera : MonoBehaviour {

	private Camera mainCamera;
	// Use this for initialization
	void Start () {
		//get the main camera
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		//follow the main camera /w rotation
		gameObject.transform.rotation = mainCamera.transform.rotation;
		gameObject.transform.position = mainCamera.transform.position;
	}
}
