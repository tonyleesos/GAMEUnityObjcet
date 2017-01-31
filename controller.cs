using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	public int totalEnemyCount = 0;
	public int maxEnemyCount=6;
	public GameObject enemy;

	public Transform Tran_CreatPoint;//物件要生成的位置
	public Vector3 V3_Random;//隨機生成位置

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetButtonDown ("Fire1") && totalEnemyCount < maxEnemyCount ) {
			V3_Random = new Vector3(Random.Range(-1.1f,1.1f),5,Random.Range(-1.1f,1.1f));
			totalEnemyCount++;
			GameObject Obj_Clone = Instantiate (enemy, V3_Random, Quaternion.identity) as GameObject;
		}
	}

}
