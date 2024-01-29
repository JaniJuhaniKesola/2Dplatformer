using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompletionHandler : MonoBehaviour
{
    public GameObject guidePlayer;
    public GameObject levelPassedText;
    public TextMeshProUGUI coinCountText;
    private bool playerInArea = false;
    private TrackCoins trackCoins; // Reference to the TrackCoins script

    private void Awake ()
    {
        trackCoins = GameObject.FindObjectOfType<TrackCoins>(); // Find the TrackCoins script
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            guidePlayer.SetActive(true);
            playerInArea = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            guidePlayer.SetActive(false);
            playerInArea = false;
        }
    }

    private void Update()
    {
        if (playerInArea && Input.GetKeyDown(KeyCode.E))
        {
            guidePlayer.SetActive(false);
            levelPassedText.SetActive(true);
            coinCountText.text = "Coins collected: " + trackCoins.coinCount; // Update the text
            StartCoroutine(ReloadSceneAfterDelay(3));
        }
    }
      
    IEnumerator ReloadSceneAfterDelay(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}