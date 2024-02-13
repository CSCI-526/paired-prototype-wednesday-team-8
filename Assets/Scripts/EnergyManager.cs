using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{

    public Image energybar;
    public Image sizebar;
    public float energyamount = 100f;
    public float sizeamount = 100f;

    void Start()
    {
        energyamount = 40f;
        energybar.fillAmount = energyamount / 100f;

        sizeamount = 15f;
        sizebar.fillAmount = sizeamount / 100f;

    }

    void Update()
    {

        if (energyamount <= 0)
        {
            SceneManager.LoadScene(0);
        }

        if (sizeamount <= 0)
        {
            SceneManager.LoadScene(0);
        }

    }


    // UI
    public void Takedamage(float damage)
    {
        energyamount -= damage;
        energybar.fillAmount = energyamount / 100f;

    }

    public void Heal(float healingAmount)
    {
        energyamount += healingAmount;
        energyamount = Mathf.Clamp(energyamount, 0, 100);

        energybar.fillAmount = energyamount / 100f;
    }

    public void Reducesize(float damage)
    {
        sizeamount -= damage;
        sizebar.fillAmount = sizeamount / 100f;
    }

    public void Increasesize(float healingAmount)
    {
        sizeamount += healingAmount;
        sizeamount = Mathf.Clamp(sizeamount, 0, 100);

        sizebar.fillAmount = sizeamount / 100f;
    }



    // OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Energy_inc"))
        {
            Heal(20);

            Destroy(other.gameObject);

            Debug.Log(energybar);
        }

        if (other.gameObject.CompareTag("Energy_dec"))
        {
            Takedamage(10);

            Destroy(other.gameObject);

            Debug.Log(energybar);
        }

        if (other.gameObject.CompareTag("sizeincrease_obs"))
        {
            if (transform.localScale.x < 2.5f && transform.localScale.y < 2.5f && transform.localScale.z < 2.5f)
            {
                Increasesize(20);
                transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            }
            
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("sizedecrease_obs"))
        {
            Reducesize(15);
            transform.localScale -= new Vector3(0.15f, 0.15f, 0.15f);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("rightpath"))
        {
            if (transform.localScale.x < 2.5f && transform.localScale.y < 2.5f && transform.localScale.z < 2.5f)
            {
                Increasesize(30);
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            }
        }

        if (other.gameObject.CompareTag("wrongpath"))
        {
            Reducesize(20);
            transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);

            if (transform.localScale == new Vector3(0,0,0))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (other.gameObject.CompareTag("hill_coll_engry_dec"))
        {

            Takedamage(10);

            Destroy(other.gameObject);

            Debug.Log(energybar);
        }


    }


}
