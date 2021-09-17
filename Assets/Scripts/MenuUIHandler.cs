using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField InputField;
    public TMP_Text BestScoreText;

    private void Start()
    {
        BestScoreText.text = "best score: " + PlayerManager.Instance.PlayerName + ": " + PlayerManager.Instance.BestScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        PlayerManager.Instance.NewPlayerName = InputField.text;
    }
}
