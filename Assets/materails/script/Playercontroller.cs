using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Playercontroller : MonoBehaviour {

//-------------------------------------------------------public宣告----------------------------------------------------------
	public float speed = 500; // force
	public Text countText;
	public Text countTime;
	public Text WinText;
	public Text LoseText;
	public GameObject gameover;
	public int WinCount;
//---------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------private宣告--------------------------------------------------------
	private Rigidbody rb;
	private int count = 0;
	private float time = 0;
	private int timer = 0;

    private bool isGround;
//---------------------------------------------------------------------------------------------------------------------------	


	void Start(){
		rb = GetComponent<Rigidbody>();  

		count = 0;
		time = 20;
		countText.text = "Count : " + count.ToString ();
		countTime.text = "Time : " + time.ToString ();
		SetCountText ();
		SetTimeText ();
		WinText.text = "";
		LoseText.text = "";
	} // Start()

	void Update () {
		time = time - Time.deltaTime;
		timer = (int)time;
		SetTimeText ();
//		/////////////////////////////////////////////////////////////////////////////////////////////////////////

//		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	} // Update
	
	void FixedUpdate(){

        isGround = Physics.Raycast(transform.position, -Vector3.up, 0.05F);
        if (isGround) {
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce( new Vector3( 0, speed, 0 ), ForceMode.Force );
            isGround = false;
        } // if 

        //float moveHorizontal = 0;//Input.GetAxis ("Horizontal"); 
        //float moveVertical = 0;//Input.GetAxis ("Vertical");

        //Vector3 movement = new Vector3( moveHorizontal, 0.0f , moveVertical );
        //rb.AddForce ( movement * speed );

    } // FixUpdate()

	void OnTriggerEnter ( Collider other ) {				// 檢取場上方礦塊count
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);
			count = count + 1;								// count++
			SetCountText ();
		} //if
	}

	void SetCountText () {									// 當檢完場上全部方塊 get Win !!
		countText.text = "Count : " + count.ToString ();
		if (count >= WinCount) {
			WinText.text = "YOU WIN!!!!";
			gameover.SetActive(true);
		} // if 
	} // SetCount ()

	void SetTimeText () {								     // 設定遊戲時間 時間到 lose !!
		countTime.text = "Time : " + timer.ToString ();
		if (time <= 0) {
			if( count < 10 ) {
				LoseText.text = "YOU Lose!!!!";
				time = 0;
				gameover.SetActive(true);
			} // if
		} // if 
	} // SetCount ()

}
