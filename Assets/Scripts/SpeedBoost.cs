using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedMultiplier = 1.5f; // Increase speed by 50%
    public float powerUpDuration = 5f; // Duration of the power-up effect

    private float normalSpeed; // Store the normal speed of the object
    private bool isPoweredUp = false; // Flag to track if object is currently powered up
    private float powerUpTimer = 0f; // Timer to track the duration of power-up

    // Start is called before the first frame update
    void Start()
    {
        normalSpeed = GetComponent<Rigidbody2D>().velocity.magnitude; // Store the initial speed
    }

    // Update is called once per frame
    void Update()
    {
        if (isPoweredUp)
        {
            powerUpTimer -= Time.deltaTime; // Decrease timer
            if (powerUpTimer <= 0f)
            {
                // If timer reaches 0, revert to normal speed
                GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * normalSpeed;
                isPoweredUp = false;
            }
        }
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp"))
        {
            if (!isPoweredUp)
            {
                // If not already powered up, increase speed
                GetComponent<Rigidbody2D>().velocity *= speedMultiplier;
                isPoweredUp = true;
                powerUpTimer = powerUpDuration;
            }
            else
            {
                // If already powered up, reset timer
                powerUpTimer = powerUpDuration;
            }
        }
    }
}
