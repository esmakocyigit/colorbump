using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDownMove : MonoBehaviour
{
    public float speed, distance;
    private float minY, maxY;

    public bool up, dontMove;
    private bool stop;

    private void Start()
    {
        maxY = transform.position.y + distance;
        minY = transform.position.y - distance;
    }

    private void Update()
    {
        if (!dontMove)
        {
            if (up)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                if (transform.position.y >= maxY)
                    up = false;
            }
            else
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                if (transform.position.y <= minY)
                    up = true;
            }
        }
    }
}
