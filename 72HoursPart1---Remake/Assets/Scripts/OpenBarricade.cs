using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBarricade : MonoBehaviour {

    public GameObject Cannon;
    public bool CannonFired = false;

	// 
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing we bumped into is an enemy
        if (collision.collider.GetComponent<Player>())
        {
            // die
            CannonFired = true;
        }
    }
}
