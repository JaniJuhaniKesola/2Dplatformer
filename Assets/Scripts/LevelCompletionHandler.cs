using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletionHandler : MonoBehaviour
{
    public GameObject guidePlayer;
    public GameObject levelPassedText;
    private bool playerInArea = false;

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
            StartCoroutine(ReloadSceneAfterDelay(3));
        }
    }
      
    IEnumerator ReloadSceneAfterDelay(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}