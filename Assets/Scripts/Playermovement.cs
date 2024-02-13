using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float movespeed = 10f;
    public float leftspeed = 4.0f;
    public float rightspeed = 4.0f;
    public float jumpspeed = 3000.0f;
    private Rigidbody rb;
    public bool isjumping;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime, Space.World);

        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (this.gameObject.transform.position.x > boundries.leftside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftspeed);
            }
        }

        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (this.gameObject.transform.position.x < boundries.rightside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * -rightspeed);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rightpath"))
        {
            movespeed += 2;
            collectable_coin_control.coinCount += 5;
        }

        if (other.gameObject.CompareTag("wrongpath"))
        {
            movespeed += 2;
            collectable_coin_control.coinCount -= 5;
        }
    }

}
