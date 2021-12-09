using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float xSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");

        float xOffset = horizontal * xSpeed * Time.deltaTime;
        float xNewPosistion = xOffset + transform.localPosition.x;


        transform.localPosition = new Vector3(Mathf.Clamp(xNewPosistion, -20,20), transform.localPosition.y, transform.localPosition.z);        
    }
}
