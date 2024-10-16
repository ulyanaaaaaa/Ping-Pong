using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            move = -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move = speed * Time.deltaTime;
        }

        transform.position = new Vector3(transform.position.x + move, transform.position.y, transform.position.z);
    }
}