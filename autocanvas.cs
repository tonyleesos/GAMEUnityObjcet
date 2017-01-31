using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class autocanvas : MonoBehaviour {




	//public CanvasScaler canvasScaler;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
//		float screenWidthScale = Screen.width / canvasScaler.referenceResolution.x;
//		float screenHidthScale = Screen.height / canvasScaler.referenceResolution.y;
//		canvasScaler.matchWidthOrHeight = screenWidthScale > screenHidthScale ? 1 : 0;
	}

	void Awake(){
		CanvasScaler canvasScaler = GetComponent<CanvasScaler> ();
		float screenWidthScale = Screen.width / canvasScaler.referenceResolution.x;
		float screenHeighScale = Screen.height / canvasScaler.referenceResolution.y;

		canvasScaler.matchWidthOrHeight = screenWidthScale > screenHeighScale ? 1 : 0;
	}

}
