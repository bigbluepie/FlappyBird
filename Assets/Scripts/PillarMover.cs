using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMover : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed = 2f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0f, 0f);
    }
}
