using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour {

    private Rigidbody2D rBody;
    public float speed;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
        //rBody.velocity = this.transform.right * speed;

        float moveHorizontal = speed;
        float moveVertical = 2;
        
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rBody.velocity = movement * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //GameObject o = Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
    //GetComponent.<Rigidbody2D>.velocity = new Vector2(3, 3);
 

    /* private Rigidbody2D rBody;
    public float speed;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
        rBody.velocity = this.transform.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
