using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour {

    private Rigidbody2D rBody;
    public float speed;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
        rBody.velocity = this.transform.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
