using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitten : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    public event Action RecievedPoint; // объявлем ивент, на который подпишем класс ScoreCounter
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.up * _speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ScoreZone"))
        {
            RecievedPoint?.Invoke(); //Вызываем ивент ReceivedPoint
        }
    }
}
