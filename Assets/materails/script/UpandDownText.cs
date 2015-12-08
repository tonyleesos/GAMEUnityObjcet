using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpandDownText : MonoBehaviour {
	public GameObject plane;
	public GameObject controlPack;

	public int LevelX, LevelZ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Text> ().text = "X:" + plane.transform.eulerAngles.x + "\nZ:" + controlPack.transform.eulerAngles.z;
		if ( 180 < plane.transform.eulerAngles.x && plane.transform.eulerAngles.x < 360 ) 
			LevelX = 1;	

		GetComponent<Text> ().text = "X:" + LevelX.ToString() + "\nZ:" + LevelZ.ToString();
	}
}
