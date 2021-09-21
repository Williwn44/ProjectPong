using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreBase : MonoBehaviour
{
    public static HighScoreBase Instance;

    private string KeyToSave = "KeyHighScore";
   
   [Header("References")]
    public TextMeshProUGUI uiHighScore;

    private void Awake()
    {
        Instance = this;
    }
    public void OnEnable()
    {
        UpdateText();
    }
    private void UpdateText()
    {
        uiHighScore.text = PlayerPrefs.GetString(KeyToSave, "No HighScore");
    }
    public void SavePlayerwin(Player p)
    {
        if (p.PlayerName == "") return;
        PlayerPrefs.SetString(KeyToSave, p.PlayerName);
        UpdateText();
    }
}
