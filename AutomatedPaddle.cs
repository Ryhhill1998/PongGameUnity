using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomatedPaddle : MonoBehaviour
{
    [SerializeField] float paddleSpeed = 10f;
    Rigidbody2D ball;

    private void Start() 
    {
        ball = FindObjectOfType<Rigidbody2D>();
    }

    void Update()
    {
        float paddlePositionY = transform.position.y;

        if (ball.velocity.x < 0 && ball.transform.position.x < 0)
        {
            float ballPositionY = ball.transform.position.y;
            float differenceY = ballPositionY - paddlePositionY;
            
            if (differenceY > 0) 
                MovePaddleUp();
            else if (differenceY < 0)
                MovePaddleDown();
        }
        else
        {
            if (paddlePositionY > 0.5) 
                MovePaddleDown();
            else if (paddlePositionY < -0.5)
                MovePaddleUp();
        }
    }

    private void MovePaddleDown()
    {
        transform.Translate(0, -paddleSpeed * Time.deltaTime, 0);
    }

    private void MovePaddleUp()
    {
        transform.Translate(0, paddleSpeed * Time.deltaTime, 0);
    }
}
