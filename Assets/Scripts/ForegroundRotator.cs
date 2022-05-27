using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForegroundRotator : MonoBehaviour
{
    [SerializeField] private Transform _leftBorder;
    [SerializeField] private Transform _rightBorder;

    [SerializeField] private float _speed;

    [SerializeField] private GameObject[] _foregrounds;

    private void FixedUpdate()
    {
        ReturnToStart();
        Move();
    }

    private void Move()
    {
        foreach (GameObject foreground in _foregrounds)
        {
            foreground.transform.Translate(_speed * (-1) * Time.fixedDeltaTime, 0f, 0f);
        }
    }

    private void ReturnToStart()
    {
        foreach (GameObject foreground in _foregrounds)
        {
            Vector3 transformPosition = foreground.transform.position;
            if (transformPosition.x <= _leftBorder.transform.position.x)
            {
                transformPosition.x = _rightBorder.transform.position.x;
            }

            foreground.transform.position = transformPosition;
        }
    }
}
