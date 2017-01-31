using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class autocamera : MonoBehaviour {

	public float baseWidth = 1024;
	public float baseHeight = 768;
	public Camera mainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake(){
		mainCamera.aspect = this.baseWidth / this.baseHeight;
//		float newSize = (float)Screen.height / (float)Screen.width * 1024 / 768 * 5;
//		mainCamera.orthographicSize = Mathf.Max ( newSize, 5 );
	}

}
