using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Shoot : MonoBehaviour
{
    private float shoot = 0;
    public GameObject bullet;
    public float fireRate = 3f;

    float timer = 10f;
    bool start = false;



    void Update()
    {
        shoot = Input.GetAxis("Fire1");

        if (shoot == 1 && timer >= fireRate)
        {
            start = true;
            timer = 0f;
            GameObject newBullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500, ForceMode.VelocityChange);
        }
        if (start)
        {
            if (timer < fireRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = fireRate;
                start = false;
            }
        }
    }
}
