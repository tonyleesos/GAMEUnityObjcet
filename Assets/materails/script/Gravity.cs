using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Gravity : MonoBehaviour {

    public float speed = 500; // force
    
    private Rigidbody rb;
    private bool isGround;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        isGround = Physics.Raycast(transform.position, -Vector3.up, 0.5F);
        if (isGround)
        {
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(new Vector3(0, speed, 0), ForceMode.Force);
            isGround = false;
        } // if 

    } // FixUpdate()
}
