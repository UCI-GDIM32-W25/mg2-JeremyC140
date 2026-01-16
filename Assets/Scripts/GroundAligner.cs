using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAligner : MonoBehaviour
{
    void Start()
    {
        Camera cam = Camera.main;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        // Camera bounds
        float camHeight = cam.orthographicSize * 2f;
        float camWidth = camHeight * cam.aspect;

        // Sprite size (world units)
        float groundHeight = sr.bounds.size.y;

        // Sprite Width
        float spriteWidth = sr.bounds.size.x;
        float scaleX = camWidth / spriteWidth;
        transform.localScale = new Vector3(scaleX, transform.localScale.y, 1f);

        Vector3 pos = cam.transform.position;

        // Center horizontally
        pos.x = cam.transform.position.x;

        // Sit on bottom of screen
        pos.y = cam.transform.position.y
              - cam.orthographicSize
              + groundHeight / 2f;

        transform.position = pos;
    }
}
