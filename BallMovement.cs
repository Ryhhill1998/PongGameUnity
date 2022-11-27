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
        rb2d.AddForce(GetRandomForce());
    }

    private Vector2 GetRandomForce()
    {
        int randomInt = Random.Range(0, 4);

        if (randomInt == 0)
        {
            SetStartingPosition(2);
            return new Vector2(ballSpeed, ballSpeed);
        }
        else if (randomInt == 1)
        {
            SetStartingPosition(1);
            return new Vector2(-ballSpeed, ballSpeed);
        }
        else if (randomInt == 2)
        {
            SetStartingPosition(3);
            return new Vector2(ballSpeed, -ballSpeed);
        }
        else
        {
            SetStartingPosition(4);
            return new Vector2(-ballSpeed, -ballSpeed);
        }       
    }

    private void SetStartingPosition(int quadrant)
    {
        float initialX = 8f;
        float initialY = 4f;

        if (quadrant == 2)
            initialX *= -1;
        else if (quadrant == 3)
        {
            initialX *= -1;
            initialY *= -1;
        }
        else if (quadrant == 4)
            initialY *= -1;

        transform.position = new Vector2(initialX, initialY);
    }
}
