using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameblood : MonoBehaviour {
	private Image bar ;
	public float fullHP = 100;
	private float actualHP = 100;
	public float HPspeed = 5f;

	// Use this for initialization
	void Start () {
		actualHP = fullHP;
		bar = GetComponent<Image>();	
	}
	
	// Update is called once per frame
	void Update () {
		actualHP = actualHP - ( HPspeed * Time.deltaTime ) ;
		bar.fillAmount = actualHP / fullHP;
	}
}
