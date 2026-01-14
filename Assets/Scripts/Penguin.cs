using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _penguinRigidbody;
    [SerializeField] private float _jumpForce = 2.0f;
    [SerializeField] private GameController _gameController;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Contact with coin");
        if (collision.gameObject.tag == "Coin") {
            _gameController.collectCoin(collision.gameObject);
        }
    }
}
