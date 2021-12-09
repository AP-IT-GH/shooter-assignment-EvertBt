using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    private bool check = true;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            if (check)
            {
                check = false;
                Text score = GameObject.Find("Score").GetComponent<Text>();
                score.text = (int.Parse(score.text) + 1).ToString();
            }
        }
    }
}
