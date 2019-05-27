using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private GameObject wayPoint;

    private Vector3 wayPointPos;

    //This will be the zombie's speed. Adjust as necessary.
    private float speed = 3.0f;

    // Use this for initialization
    void Start () {


        //At the start of the game, the zombies will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");

    }
	
	// Update is called once per frame
	void Update () {

        wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);

        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);

    }
}
