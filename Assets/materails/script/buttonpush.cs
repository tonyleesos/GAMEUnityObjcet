using UnityEngine;
using System.Collections;

public class buttonpush : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void change(string scene ) {
		Application.LoadLevel ( scene );

	}
}
