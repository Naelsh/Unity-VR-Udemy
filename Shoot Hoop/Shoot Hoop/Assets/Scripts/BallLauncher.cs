using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

    public float ballVelocity = 5f;
    public GameObject basketBallPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            InstantiateBall(Vector3.forward);
        }
    }

    public void InstantiateBall(Vector3 direction)
    {
        GameObject basketball = Instantiate(basketBallPrefab);
        basketball.transform.position = transform.position;
        Rigidbody basketBallRB = basketball.GetComponent<Rigidbody>();
        basketBallRB.velocity = direction * ballVelocity;
    }
}
