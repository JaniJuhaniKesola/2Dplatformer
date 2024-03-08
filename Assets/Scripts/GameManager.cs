using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private float _score;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(float coinValue)
    {
        _score += coinValue;
    }

    public float GetScore()
    {
        return _score;
    }
}