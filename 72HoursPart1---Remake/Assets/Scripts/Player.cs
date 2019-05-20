using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // designer variables
    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    //In the editor, add your wayPoint gameobject to the script.
    public GameObject wayPoint;
    //This is how often your waypoint's position will update to the player's position
    private float timer = 0.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);
        float upDown = Input.GetAxis(verticalAxis);

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate velocity
        Vector2 velocity = direction * speed;

        // Give the velocity to the rigidbody
        physicsBody.velocity = velocity;

        // Update waypoint
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            //The position of the waypoint will update to the player's position
            UpdatePosition();
            timer = 0.5f;
        }

    }

    void UpdatePosition()
    {
        //The wayPoint's position will now be the player's current position.
        wayPoint.transform.position = transform.position;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing we bumped into is an enemy
        if (collision.collider.GetComponent<Enemy>())
        {
            // die
            Destroy(gameObject);
        }
    }


}
