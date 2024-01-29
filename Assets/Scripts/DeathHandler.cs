using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    public GameObject gameOverText; // Reference to the Text object

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject); // Destroy the player object
            gameOverText.SetActive(true); // Show the message
            StartCoroutine(ReloadSceneAfterDelay(2)); // Wait for 2 seconds and then reload the scene
        }
    }

    IEnumerator ReloadSceneAfterDelay(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the game scene
    }
}