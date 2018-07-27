using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 100f;
    public float turnSpeed = 5f;
	void Start () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * turnSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
