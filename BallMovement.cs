using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float ballSpeed = 0.025f;

    void Update()
    {
        transform.Translate(0, ballSpeed * Time.deltaTime, 0);
    }
}
