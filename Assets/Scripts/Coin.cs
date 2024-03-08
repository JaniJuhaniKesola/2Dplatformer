using UnityEngine;

public class Coin : MonoBehaviour
{
    // Set the amount of points to give
    public int points = 10;

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Assuming you have a scoring system in your game
            // You can call a method to add points here
            // GameManager.instance.AddPoints(points);

            // You can also destroy the coin after collecting it
            Destroy(gameObject);
        }
    }
}