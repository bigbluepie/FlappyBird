using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TMP_Text _textBox;

    private void Start()
    {
        _score = 0;
        _textBox = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _textBox.text = _score.ToString();
    }
}
