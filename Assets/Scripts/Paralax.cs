using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] Transform _returnPoint;
    [SerializeField] Transform _startPoint;

    private float _speed = 3f;

    private void Update()
    {
        
        if (transform.position.x > _returnPoint.position.x)
        {
            transform.Translate(-_speed * Time.deltaTime, 0f, 0f);
        }
        else 
        {
            transform.position = new Vector3(_startPoint.position.x, transform.position.y, transform.position.z);
        }
    }
}
