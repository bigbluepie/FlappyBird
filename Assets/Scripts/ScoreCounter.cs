using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _textBox;
    [SerializeField] private Kitten _kitten;
    private void Start()
    {
        _score = 0;

        _kitten.RecievedPoint += AddScore;
    }

    private void AddScore()
    {
        _score++;
        _textBox.text = _score.ToString();
    }


}
