using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        collectable_coin_control.coinCount += 1;
       
    }

}
