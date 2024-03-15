using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int _score;
    private readonly string _scorePlayerPrefsKey = "Score";

    public int Score => _score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        _score = PlayerPrefs.GetInt(_scorePlayerPrefsKey, 0);
    }

    public void AddScore(int scoreValue)
    {
        _score += scoreValue;
        PlayerPrefs.SetInt(_scorePlayerPrefsKey, _score);
    }

    public void ResetScore()
    {
        _score = 0;
        PlayerPrefs.SetInt(_scorePlayerPrefsKey, _score);
    }
}
