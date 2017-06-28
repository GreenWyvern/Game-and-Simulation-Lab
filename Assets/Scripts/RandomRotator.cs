using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    private Rigidbody2D rb;
    public float rotate;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.value * rotate;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
