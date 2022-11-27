using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "TopWall")
        {
            float incomingAngle = GetIncomingAngle();
            float reflectionAngle = GetReflectionAngle(incomingAngle);
            if (incomingAngle > 270 && incomingAngle < 360)
            {
                reflectionAngle += 180;
            }
            transform.Rotate(0, 0, reflectionAngle - incomingAngle);
        }
        else if (other.gameObject.tag == "BottomWall")
        {
            float incomingAngle = GetIncomingAngle();
            float reflectionAngle = GetReflectionAngle(incomingAngle);
            if (incomingAngle < 180)
            {
                reflectionAngle += 180;
            }
            transform.Rotate(0, 0, reflectionAngle - incomingAngle);
        }
        else if (other.gameObject.tag == "LeftWall")
        {
            float incomingAngle = GetIncomingAngle();
            float reflectionAngle = GetReflectionAngle(incomingAngle);
            if (incomingAngle < 90)
            {
                reflectionAngle += 180;
            }
            transform.Rotate(0, 0, reflectionAngle - incomingAngle);
        }
        else if (other.gameObject.tag == "RightWall")
        {
            float incomingAngle = GetIncomingAngle();
            float reflectionAngle = GetReflectionAngle(incomingAngle);
            if (incomingAngle < 270)
            {
                reflectionAngle += 180;
            }
            transform.Rotate(0, 0, reflectionAngle - incomingAngle);
        }
    }

    private float GetIncomingAngle()
    {
        return transform.localEulerAngles.z;
    }

    private float GetReflectionAngle(float angle)
    {
        float incidentAngle = angle % 90;
        return 180 + angle - 2 * incidentAngle;
    }
}
