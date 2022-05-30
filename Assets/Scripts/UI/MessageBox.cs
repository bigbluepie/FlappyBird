using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class MessageBox : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private TMP_Text _text;
    private String[] _textArray = {"GET READY", "GO", "PAUSED", "GAME OVER"};
    [SerializeField] private Color[] _colorArray;

    [SerializeField] private GameObject _startScreen;

    private void Awake()
    {
        _game.GameStateChanged += ChangeText;
    }

    private void ChangeText(GameStates gameState)
    {
        switch (gameState)
        {
            case GameStates.Start:
                _text.text = _textArray[0];
                _text.color = _colorArray[2];
                _text.fontSize = 120f;
                _startScreen.SetActive(true);
                break;
            case GameStates.Play:
                _startScreen.SetActive(false);
                StartCoroutine(ShowGoText());
                break;
            case GameStates.Pause:
                _text.text = _textArray[2];
                _text.color = _colorArray[0];
                _text.fontSize = 120f;
                break;
            case GameStates.Defeat:
                _text.text = _textArray[3];
                _text.color = _colorArray[3];
                _text.fontSize = 120f;
                break;
            default:
                
                break;
        }
    }

    IEnumerator ShowGoText()
    {
        _text.text = _textArray[1];
        _text.color = _colorArray[1];
        _text.fontSize = 240f;
        yield return new WaitForSeconds(0.5f);
        _text.color = _colorArray[4];
    }
}
