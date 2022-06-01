using UnityEngine;

public class HighScoreSaveLoader: MonoBehaviour
{
    private int _highScore;
    public int HighScore => _highScore;
    private const string HIGH_SCORE_KEY = "SavedHighScore";
    public void SaveScore(int score)
    {
        _highScore = score;
        PlayerPrefs.SetInt(HIGH_SCORE_KEY, _highScore);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        if (PlayerPrefs.HasKey(HIGH_SCORE_KEY))
        {
            _highScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY);
        }
        else _highScore = 0;
    }
}
