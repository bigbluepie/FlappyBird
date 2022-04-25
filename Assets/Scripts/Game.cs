using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Game : MonoBehaviour
{
    private GamePhase _gamePhase;
    public event Action ChangedState; //объявляем событие изменения состояния игры

    private void Start()
    {
        _gamePhase = GamePhase.Start;
    }

    private void Update() //переделать на свитч, а позже на стейтмашину
    {
        if (_gamePhase == GamePhase.Start)
        {
            Time.timeScale = 0f;
            if (Input.GetMouseButtonDown(0))
            {
                ChangeState(GamePhase.Play);
            }
        }
        else if (_gamePhase == GamePhase.Play)
        {
            Time.timeScale = 1f;
        }
        else if (_gamePhase == GamePhase.Pause)
        {
            Time.timeScale = 0f;
        }
        else if (_gamePhase == GamePhase.Defeat)
        {
            Time.timeScale = 0f;
        }
    }

    public void ChangeState(GamePhase gamephase)
    {
        _gamePhase = gamephase;
    }

    public enum GamePhase
    {
        Start,
        Play,
        Pause,
        Defeat
    }
}
