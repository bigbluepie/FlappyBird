using System;
using UnityEngine;

public class Game: MonoBehaviour
{
    public event Action<GameStates> GameStateChanged;
    [SerializeField] private GameStates _gameState;
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