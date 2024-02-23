using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public Image jumpButtonImage; // Reference to the UI Image for jumping

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Add a pointer click event listener to the UI image
        jumpButtonImage.GetComponent<Button>().onClick.AddListener(Jump);
    }

    void OnDestroy()
    {
        // Remove the pointer click event listener from the UI image
        jumpButtonImage.GetComponent<Button>().onClick.RemoveListener(Jump);
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}