using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 20;
            }
            else
            {
                speed = 10;
            }
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }
}