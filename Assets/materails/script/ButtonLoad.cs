using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonLoad : MonoBehaviour {
	
	public string scene = "";
	void Start ()
	{
		//定义Action，并赋予delegate方法
		//UnityAction<Button> btnActions = new UnityAction<Button>();
		//找到Button控件，并订阅事件
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(delegate {
			Application.LoadLevel(scene);
		});
	}
}
