using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float rotationSpeed = 60f;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        
        transform.rotation *= Quaternion.Euler(-(mouseY * Time.deltaTime * rotationSpeed), 0, 0);
        transform.parent.transform.rotation *= Quaternion.Euler(0, mouseX * Time.deltaTime * rotationSpeed, 0);
	}
}
