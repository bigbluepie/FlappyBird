using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Pig : MonoBehaviour
{
    [SerializeField] private Game _game;

    private bool _underControl;
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    public event Action RecievedPoint;

    private void Awake()
    {
        _game.GameStateChanged += SetState;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void SetState(GameStates gameState)
    {
        switch (gameState)
        {
            case GameStates.Start:
                _underControl = true;
                _rb.gravityScale = 0f;
                break;
            case GameStates.Play:
                _underControl = true;
                _rb.gravityScale = 1f;
                break;
            case GameStates.Pause:
                _underControl = false;
                _rb.gravityScale = 0f;
                break;
            case GameStates.Defeat:
                _underControl = false;
                _rb.gravityScale = 1f;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (_underControl)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rb.velocity = Vector3.up * _speed;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreZone"))
        {
            RecievedPoint?.Invoke();
        }
    }
}
