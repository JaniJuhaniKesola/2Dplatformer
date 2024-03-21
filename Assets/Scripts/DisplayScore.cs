using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _displayScore;

    void Update()
    {
        _displayScore.text = "Score: " + GameManager.Instance.Score;
    }
}
