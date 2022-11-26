using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "BottomWall" || other.gameObject.tag == "RightWall")
        {
            if (transform.localEulerAngles.z < 180 && transform.localEulerAngles.z > 90)
            {
                DecreaseRotation();
            }
            else
            {
                IncreaseRotation();
            }
        }
        else if (other.gameObject.tag == "LeftWall")
        {
            if (transform.localEulerAngles.z > 0 && transform.localEulerAngles.z < 90)
            {
                DecreaseRotation();
            }
            else
            {
                IncreaseRotation();
            }
        }
        else if (other.gameObject.tag == "TopWall")
            if (transform.localEulerAngles.z > 270 && transform.localEulerAngles.z < 360)
            {
                DecreaseRotation();
            }
            else
            {
                IncreaseRotation();
            }
    }

    private void IncreaseRotation()
    {
        transform.Rotate(0, 0, 90);
    }

    private void DecreaseRotation()
    {
        transform.Rotate(0, 0, -90);
    }
}
