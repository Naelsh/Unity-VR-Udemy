using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float rotationSpeed = 30f;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        
        transform.rotation *= Quaternion.Euler(-(mouseY * Time.deltaTime * rotationSpeed), mouseX * Time.deltaTime * rotationSpeed, 0);
	}
}
