using UnityEngine;
using UnityEngine.UI;

public class ResetScoreOnClick : MonoBehaviour
{
    private Button resetButton;

    private void Start()
    {
        resetButton = GetComponent<Button>();
        resetButton.onClick.AddListener(OnResetButtonClick);
        
    }

    private void OnDestroy()
    {
        resetButton.onClick.RemoveListener(OnResetButtonClick);
    }

    private void OnResetButtonClick()
    {
        
        GameManager.Instance.ResetScore();
    }
}
