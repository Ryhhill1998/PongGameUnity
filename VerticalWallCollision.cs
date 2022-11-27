using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerticalWallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        // reset ball to centre
        SceneManager.LoadScene(0);
    }
}
