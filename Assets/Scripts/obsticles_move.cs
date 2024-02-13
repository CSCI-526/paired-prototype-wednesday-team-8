using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticles_move : MonoBehaviour
{
    [SerializeField] public float speed = 2f; 
    private bool moveRight = true;

    void Update()
    {
        MoveObstacle();
    }

    void MoveObstacle()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        
        if (transform.position.x >= 4f) 
        {
            moveRight = false;
        }
        else if (transform.position.x <= -4f) 
        {
            moveRight = true;
        }
    }
}
