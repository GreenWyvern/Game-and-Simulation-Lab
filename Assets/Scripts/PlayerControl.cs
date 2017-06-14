using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;
    Rigidbody2D rBody;
    public Boundry boundry = new Boundry();

    [System.Serializable]
    public class Boundry
    {
    public float yMin, yMax, xMin, xMax;
    }
    
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //this.GetComponent<Rigidbody2D>();

        
        rBody.velocity = movement * speed;
        rBody.position = new Vector2(Mathf.Clamp(rBody.position.x, boundry.xMin, boundry.xMax), Mathf.Clamp(rBody.position.y, boundry.yMin, boundry.yMax));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
