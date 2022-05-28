using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _offsetX;

    private void LateUpdate()
    {
        var transformPosition = transform.position;
        transformPosition.x = _target.position.x + _offsetX;
        transform.position = transformPosition;
    }
}
