using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    float diagonalSpeed;
    Vector2 movement;
    void Start()
    {
        diagonalSpeed = speed / 1.41f;
    }
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if (inputX != 0 && inputY != 0) movement = new Vector2(diagonalSpeed * inputX, diagonalSpeed * inputY);
        else movement = new Vector2(speed * inputX, speed * inputY);

        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
