using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoConnectUnity : MonoBehaviour {
	public static string[] vec3;
	SerialPort sp = new SerialPort("COM5" , 115200);
	float m, WiiPitch, WiiRoll ;
	// Use this for initialization
	void Start () {
		sp.Open();
	} // Start()
	
	// Update is called once per frame
	void Update () {
		if(sp.IsOpen) {		   
			string value = sp.ReadLine();
			vec3 = value.Split(',');
			print( vec3[0] + " " + vec3[1] );             // wiipitch   // roll

			//print(",");


//				if( sp.ReadLine() == "Wii.getPitch()" )
//					float.TryParse ( sp.ReadLine() , out WiiPitch );
//				if( sp.ReadLine() == "Wii.getRoll()" )
//					float.TryParse ( sp.ReadLine() , out WiiRoll );

//			temp1 = sp.ReadLine(); //將資料轉成float
//			WiiPitch = float.Parse(temp1);
//			temp2 = sp.ReadLine();
//			WiiRoll = float.Parse(temp2);
				
//				print( "\n" );
//				print( WiiPitch);
//				print( WiiRoll );
		} // if

	} // Update()
}
