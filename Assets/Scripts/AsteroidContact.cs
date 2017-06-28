using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidContact : MonoBehaviour {

    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundry")
        {
            return;
        }
        Instantiate(explosion, this.transform.position, this.transform.rotation);  

        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
