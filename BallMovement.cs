using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float ballSpeed = 7f;

    private void Start() 
    {
        init();
    }

    void Update()
    {
        transform.Translate(0, ballSpeed * Time.deltaTime, 0);
    }

    private void init()
    {
        int[] initialAngles = {45, 135, 225, 315};
        transform.Rotate(0, 0, initialAngles[Random.Range(0, 4)]);
    }
}
