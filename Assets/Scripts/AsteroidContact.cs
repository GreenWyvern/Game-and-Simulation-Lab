using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject pExplosion;


    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("No game controller. There, uh... should be one.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundry")
        {
            return;
        }
        Instantiate(explosion, this.transform.position, this.transform.rotation);

        if(other.tag == "Player")
        {
            Instantiate(pExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }

        if(other.tag == "Laser")
        {
            gameController.AddScore(10);
        }
        
        if(other.tag != "Asteroid") { 
        Destroy(this.gameObject);
        Destroy(other.gameObject);
        }
    }


  
	
	// Update is called once per frame
	void Update () {
		
	}
}
