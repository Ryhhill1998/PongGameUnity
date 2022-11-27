using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] float paddleSpeed = 10f;

    void Update()
    {
        if (tag == "LeftPaddle")
        {
            if (!PaddleAtUpperBoundary() && Input.GetKey(KeyCode.W))
            {
                float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
                transform.Translate(0, moveAmount, 0);
            }
            else if (!PaddleAtLowerBoundary() && Input.GetKey(KeyCode.S))
            {
                float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
                transform.Translate(0, moveAmount, 0);
            }
        }
        else if (tag == "RightPaddle")
        {
            if (!PaddleAtUpperBoundary() && Input.GetKey(KeyCode.UpArrow))
            {
                float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
                transform.Translate(0, moveAmount, 0);
            }
            else if (!PaddleAtLowerBoundary() && Input.GetKey(KeyCode.DownArrow))
            {
                float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
                transform.Translate(0, moveAmount, 0);
            }
        }
    }

    private bool PaddleAtUpperBoundary()
    {
        return transform.position.y >= 5.5;
    }

    private bool PaddleAtLowerBoundary()
    {
        return transform.position.y <= -5.5;
    }
}
