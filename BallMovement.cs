using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float ballSpeed = 0.05f;
    Rigidbody2D rb2d;

    private void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(ballSpeed, ballSpeed));
    }
}
