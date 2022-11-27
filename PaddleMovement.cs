using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] float paddleSpeed = 25f;

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
        if ((PaddleAtUpperBoundary() && moveAmount > 0) || (PaddleAtLowerBoundary() && moveAmount < 0)) return;
        transform.Translate(0, moveAmount, 0);
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
