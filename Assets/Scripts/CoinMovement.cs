using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    void Update()
    {
        transform.position = Vector2.left * _speed * Time.deltaTime;
    }
}
