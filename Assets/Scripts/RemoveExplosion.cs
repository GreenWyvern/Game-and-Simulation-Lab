using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveExplosion : MonoBehaviour {

    public float tem;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, tem);
	}
	
}
