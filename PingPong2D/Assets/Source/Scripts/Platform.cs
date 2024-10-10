using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            Vector3 platformPosition = transform.position;
            platformPosition.x = Mathf.Lerp(platformPosition.x, mousePosition.x, speed * Time.deltaTime);
            transform.position = platformPosition;
        }
    }
}
