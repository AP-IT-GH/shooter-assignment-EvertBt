using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float invincibilityPeriod = 3f;

    private void Update()
    {
        invincibilityPeriod -= Time.deltaTime;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && invincibilityPeriod <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
