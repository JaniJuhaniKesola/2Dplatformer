using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    private TextMeshProUGUI _displayScore;

    void Start()
    {
        _displayScore = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _displayScore.text = "Score: " + GameManager.Instance.Score;
    }
}
