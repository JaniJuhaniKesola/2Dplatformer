using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCoins : MonoBehaviour
{
    public int coinCount = 0; // Variable to track the number of coins collected

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin")) // Check if the collided object is a coin
        {
            Destroy(other.gameObject); // Despawn the coin
            coinCount++; // Increment the coin count
            Debug.Log("Coins collected: " + coinCount); // Log the number of coins collected
        }
    }
}