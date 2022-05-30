using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    [SerializeField] private Game _game;

    private float _timeScale;

    private void Awake()
    {
        _game.GameStateChanged += ChangeTimeScale;
    }

    private void ChangeTimeScale(GameStates gameState)
    {
        switch (gameState)
        {
            case GameStates.Start:
                _timeScale = 0f;
                break;
            case GameStates.Play:
                _timeScale = 1f;
                break;
            case GameStates.Pause:
                _timeScale = 0f;
                break;
            case GameStates.Defeat:
                _timeScale = 0f;
                break;
            default:
                _timeScale = 1f;
                break;
        }

        Time.timeScale = _timeScale;
    }
}
