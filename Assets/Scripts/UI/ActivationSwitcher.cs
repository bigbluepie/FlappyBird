using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivationSwitcher : MonoBehaviour
{
    private ActivationStates _state;
    public ActivationStates State
    {
        get => _state;
    }

    public Sprite[] _sprites;
    private Button _button;
    

    private Sprite _sprite (ActivationStates state)
    {
        if (state == ActivationStates.Active)
        {
            return _sprites[0];
        }
        else
        {
            return _sprites[1];
        }
    }

    private void Awake()
    {
        _state = ActivationStates.Active;
        _button = GetComponent<Button>();
    }

    public void ChangeState()
    {
        if (_state == ActivationStates.Active)
            _state = ActivationStates.Disactive;
        else _state = ActivationStates.Active;
        ChangeSprite();
    }

    private void ChangeSprite()
    {
        _button.image.sprite = _sprite(_state);
    }
}

public enum ActivationStates
{
    Active,
    Disactive
}
