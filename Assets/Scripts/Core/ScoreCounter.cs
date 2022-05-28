using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _textBox;
    [SerializeField] private Pig _pig;
    private void Start()
    {
        _score = 0;

        _pig.RecievedPoint += AddScore;
    }

    private void AddScore()
    {
        _score++;
        _textBox.text = _score.ToString();
    }
}
