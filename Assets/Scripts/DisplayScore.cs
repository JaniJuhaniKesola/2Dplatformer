using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _displayScore;
 
    void Update()
    {
        _displayScore.text = "Score: " + GameManager.Instance.GetScore();
    }
}
