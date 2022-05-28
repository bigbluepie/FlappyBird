using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private float _destroyBorder;

    private void Start()
    {
        _destroyBorder = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * (_speed * Time.deltaTime);
        if (transform.position.x < _destroyBorder)
        {
            Destroy(gameObject);
        }
    }
}
