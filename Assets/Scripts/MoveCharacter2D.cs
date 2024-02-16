using UnityEngine;

public class MoveCharacter2D : MonoBehaviour
{
    private Rigidbody2D rb; // Reference to the Rigidbody2D component of the character
    public float moveForce = 10f; // Force applied to move the character
    public float maxSpeed = 5f; // Maximum speed the character can move

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        float moveVelocity = moveInput * moveForce;

        // Limit the velocity to the maximum speed
        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
        {
            rb.AddForce(Vector2.right * moveVelocity);
        }
    }
}
