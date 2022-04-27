using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PrepareMessenger : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private GameObject _prepareScreen;
    [SerializeField] private GameObject _goText;
    private void Start()
    {
        _game.ChangedState += Hide;
    }

    private void Hide()
    {
        _prepareScreen.SetActive(false);
        StartCoroutine(ShowGoText());
    }

    private void Show()
    {
        _prepareScreen.SetActive(true);
    }

    IEnumerator ShowGoText()
    {
        _goText.SetActive(true);
        yield return new WaitForSeconds(1f);
        _goText.SetActive(false);
    }
}
