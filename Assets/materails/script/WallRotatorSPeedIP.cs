﻿using UnityEngine;
using System.Collections;

public class WallRotatorSPeedIP : MonoBehaviour {

	public float RoatorControl;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, RoatorControl, 0) * Time.deltaTime);
	}
}
