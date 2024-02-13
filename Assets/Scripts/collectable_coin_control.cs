using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class collectable_coin_control : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
    }
}
