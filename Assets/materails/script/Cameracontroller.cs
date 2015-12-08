using UnityEngine;
using System.Collections;

public class Cameracontroller : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	public GameObject gameoverMid;
	bool isEnding = false;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	} // Start ()
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
		if ( isEnding == false ) {
			if (player.transform.position.y < -50) {
				isEnding = true;
				gameoverMid.SetActive(true);
			}
		}
	} // LateUpdate ()


}
