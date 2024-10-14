using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 10f;
    private bool isDragging = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                isDragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            Vector3 platformPosition = transform.position;
            platformPosition.x = Mathf.Lerp(platformPosition.x, mousePosition.x, speed * Time.deltaTime);
            transform.position = platformPosition;
        }
    }
}

