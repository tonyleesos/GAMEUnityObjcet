using UnityEngine;
using System.Collections;

public class PlaneRotator : MonoBehaviour {
    public float speed;

    //private Rigidbody rb;
	
    public float turnSpeed = 50f;
	public float moveSPeed = 10f;
	public bool isStart = false;

	public GameObject ControlPackage;

    // Use this for initialization
    void Start () {
        //rb = GetComponent<Rigidbody>();
        
    } // Start()

    // Update is called once per frame


    void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			isStart = true;
		} // if
		else if (Input.GetKey(KeyCode.Space)) {
			isStart = false;
		} // else if
		
		if( isStart == true )
		//WiiControl();
         KeyWordControl();   //鍵盤控制移動
        //transform.Rotate(x * Time.deltaTime * 25, 0, -z * Time.deltaTime * 25, Space.World);

   //     print( transform.rotation );

    } // Update()

	void WiiControl() {

		//float translation = Input.GetAxis( ArduinoConnectUnity.vec3[0] ) * moveSPeed;
		//float rotation = Input.GetAxis( ArduinoConnectUnity.vec3[1] ) * moveSPeed;
		bool isleft = false;
		bool isRight = false;
		bool isForward = false;
		bool isBack = false;

		//		vec3[1]  wiipitch() 後面的
		//		vec3[0]  wiiroll() 前面的

		if (float.Parse(ArduinoConnectUnity.vec3[1]) < 175 &&				// 後  
			float.Parse(ArduinoConnectUnity.vec3[1]) > 120)
			isleft = true;
		if (float.Parse (ArduinoConnectUnity.vec3 [1]) > 195 &&				// 前
			float.Parse (ArduinoConnectUnity.vec3 [1]) < 230)
			isRight = true;
		if (float.Parse(ArduinoConnectUnity.vec3[0]) < 175 &&				// 右
		    float.Parse(ArduinoConnectUnity.vec3[0]) > 120)
			isForward = true;
		if (float.Parse (ArduinoConnectUnity.vec3 [0]) > 195 &&				// 左
		    float.Parse (ArduinoConnectUnity.vec3 [0]) < 230)
			isBack = true;



	
		if (isleft && transform.rotation.x > -0.25f)
			transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
		if (isRight && transform.rotation.x < 0.25f)
			transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
		if ( isBack && transform.rotation.z < 0.25f)
			ControlPackage.transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
		if ( isForward && transform.rotation.z > -0.25f)
			ControlPackage.transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);   


		//print( ArduinoConnectUnity.vec3[0]);
		//print( ArduinoConnectUnity.vec3[1]);

	} // WiiControl()

    void KeyWordControl() {

        if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            Debug.Log("S按下一次");
            if(transform.rotation.x > -0.16f)
              transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
           
        } // if

        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            Debug.Log("W按下一次");
            if (transform.rotation.x < 0.16f)
                transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
        }// if

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            Debug.Log("A按下一次");
            if (transform.rotation.z < 0.16f)
                transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

        }// if

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            Debug.Log("D按下一次");
            if (transform.rotation.z > -0.16f)
                transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);          
        }// if

    } // KeyWordControl() 

} // MonoBehaviour()
