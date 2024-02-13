using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    Color lerpedColor = Color.white;
    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
    }

    void Update()
    {
        if (tag == "Energy_dec")
        {
            lerpedColor = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 0.7f));
            ren.material.color = lerpedColor;
        }

        if (tag == "sizedecrease_obs")
        {
            lerpedColor = Color.Lerp(Color.yellow, Color.red, Mathf.PingPong(Time.time, 0.7f));
            ren.material.color = lerpedColor;
        }
    }
}
