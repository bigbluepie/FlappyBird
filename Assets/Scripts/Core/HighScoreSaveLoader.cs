using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreSaveLoader: MonoBehaviour
{
    private int _highScore;

    public int HighScore
    {
        get { return _highScore; }
    }

    public void SaveScore(int score)
    {
        _highScore = score;
        PlayerPrefs.SetInt("SavedHighScore", _highScore);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            _highScore = PlayerPrefs.GetInt("SavedHighScore");
        }
        else _highScore = 0;
    }
}
