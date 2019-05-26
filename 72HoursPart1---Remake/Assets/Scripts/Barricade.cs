using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour {

    void Start()
    {
        if(GameObject.Find("Cannon1").GetComponent<OpenBarricade>().CannonFired == true)
        {
            Destroy(gameObject);
        }
    }
}
