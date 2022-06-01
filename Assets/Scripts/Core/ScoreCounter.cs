using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int _score;
    
    [SerializeField] private Pig _pig;
    [SerializeField] private Game _game;
    [SerializeField] private HighScoreSaveLoader _saveLoader;
    
    [SerializeField] private TMP_Text _textBox;
    [SerializeField] private TMP_Text _currentScoreTextBox;
    [SerializeField] private TMP_Text _highScoreTextBox;
    
    [SerializeField] private GameObject _newTextBox;
    
    public int CurrentScore => _score;
    private void Start()
    {
        if (PlayerPrefs.HasKey(ContinueGame.PRE_AD_SCORE))
        {
            _score = PlayerPrefs.GetInt(ContinueGame.PRE_AD_SCORE);
            _textBox.text = _score.ToString();
            PlayerPrefs.DeleteKey(ContinueGame.PRE_AD_SCORE);
        }
        else
        {
            _score = 0;
        }

        _pig.RecievedPoint += AddScore;
        _game.GameStateChanged += CheckHighScore;
    }

    private void AddScore()
    {
        _score++;
        _textBox.text = _score.ToString();
    }

    private void CheckHighScore(GameStates gameStates)
    {
        if (gameStates == GameStates.Defeat)
        {
            _currentScoreTextBox.text = _score.ToString();
            _saveLoader.LoadScore();
            
            int highscore = _saveLoader.HighScore;
            
            if (_score > highscore)
            {
                _newTextBox.SetActive(true);
                highscore = _score;
                _saveLoader.SaveScore(highscore);
            }

            _highScoreTextBox.text = highscore.ToString();
        }
    }
}
