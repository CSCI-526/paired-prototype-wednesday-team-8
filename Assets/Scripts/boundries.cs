using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundries : MonoBehaviour
{
    public static float leftside = -4f;
    public static float rightside = 4;
    public float internalleft;
    public float internalright;

    // Update is called once per frame
    void Update()
    {
        internalleft = leftside;
        internalright = rightside;
    }
}
