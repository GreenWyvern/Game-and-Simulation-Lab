using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;
    Rigidbody2D rBody;
    public Boundry boundry = new Boundry();
    public Transform laserSpawn;
    public GameObject laser;

    public float fireDelta = 0.5f;
    private float nextFire = 0.5f;
    private float myTime = 0.5f;

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
        myTime += Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
            myTime = 0;
        }
	}
}
