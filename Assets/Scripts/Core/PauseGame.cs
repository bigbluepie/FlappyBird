using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private ActivationSwitcher _switcher;
    [SerializeField] private GameObject _panel;

    public void MakePause()
    {
        if (_switcher.State != ActivationStates.Active)
        {
            _game.ChangeGameState(GameStates.Pause);
            _panel.SetActive(true);
        }
        else
        {
            _game.ChangeGameState(GameStates.Play);
            _panel.SetActive(false);
        }
    }
}
