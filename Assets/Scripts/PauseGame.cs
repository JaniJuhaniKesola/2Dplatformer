using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Check if 'P' key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Toggle pause state
            isPaused = !isPaused;

            // Pause or unpause the game based on the current state
            if (isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }

    void Pause()
    {
        // Pause the game by setting the time scale to 0
        Time.timeScale = 0f;
    }

    void Unpause()
    {
        // Unpause the game by setting the time scale back to 1
        Time.timeScale = 1f;
    }
}
