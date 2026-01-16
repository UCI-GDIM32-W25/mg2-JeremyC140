using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float coin_left_bound = -10.0f;

    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
        if (transform.position.x < coin_left_bound) {
            Destroy(this.gameObject);
        }
    }
}
