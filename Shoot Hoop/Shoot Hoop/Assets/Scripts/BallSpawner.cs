using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject basketBallPrefab;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            InstantiateBall(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            InstantiateBall(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            InstantiateBall(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            InstantiateBall(Vector3.right);
        }
    }

    void InstantiateBall(Vector3 direction)
    {
        float increasedVelocity = 5f;
        direction *= increasedVelocity;
        GameObject basketball = Instantiate(basketBallPrefab);
        Rigidbody basketBallRB = basketball.GetComponent<Rigidbody>();
        basketBallRB.velocity = direction;
    }
}
