using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigiMovement : MonoBehaviour
{
    private Vector2 velocity;
    private Rigidbody2D rb2D;
    void Awake ()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>(); // Assign the Rigidbody2D component
        /*if (rb2D == null)
        {
            rb2D = gameObject.AddComponent<Rigidbody2D>(); // Add the Rigidbody2D component if it doesn't exist
        }*/
    }

    void Start ()
    {
        velocity = new Vector2(5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2D != null) // Check if rb2D is not null before using it
        {
            if (rb2D.position.x < 9.0) // Check if the x position is less than 9
            {
                rb2D.MovePosition(rb2D.position + velocity * Time.deltaTime);
            }
        }
    }
}
