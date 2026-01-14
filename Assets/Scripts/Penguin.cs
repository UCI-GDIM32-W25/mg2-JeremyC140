using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _penguinRigidbody;
    [SerializeField] private float _jumpForce = 2.0f;
    private bool isGrounded;
    void Start()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            isGrounded = false;
            _penguinRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && !isGrounded) { 
            isGrounded = true;
        }
    }
}
