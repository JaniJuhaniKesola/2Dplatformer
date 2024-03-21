using UnityEngine;
using TMPro;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private TMP_Text _pauseText;

    public void Pause()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            _pauseText.enabled = true;
        }
        else
        {
            Time.timeScale = 1f;
            _pauseText.enabled = false;
        }
    }
}
