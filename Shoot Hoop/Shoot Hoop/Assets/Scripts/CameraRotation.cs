﻿using System.Collections;
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
        
        transform.localRotation *= Quaternion.Euler(0, mouseX * Time.deltaTime * rotationSpeed, 0);

        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation *= Quaternion.Euler(-(mouseY * Time.deltaTime * rotationSpeed), 0, 0);
	}
}
