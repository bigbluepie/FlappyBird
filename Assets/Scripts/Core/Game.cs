using System;
using UnityEngine;

public class Game: MonoBehaviour
{
    [SerializeField] private GameStates _gameState;

    public event Action<GameStates> GameStateChanged;

    private void Start()
    {
        ChangeGameState(GameStates.Start);
    }

    public void ChangeGameState(GameStates gameState)
    {
        _gameState = gameState;
        GameStateChanged?.Invoke(gameState);
    }

    public void Update()
    {
        if (_gameState == GameStates.Start && Input.GetMouseButtonDown(0))
            ChangeGameState(GameStates.Play);
    }
}

public enum GameStates
{
    Start,
    Play,
    Defeat,
    Pause
}
