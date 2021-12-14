using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    private const float maxX = 9;
    private const float minX = -9;
    private const float maxY = 5;
    private const float minY = -5;

    private void Update()
    {
        TeleportObjects();
    }

    private void TeleportObjects()
    {
        if (transform.position.x > maxX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }

        else if (transform.position.x < minX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }

        if (transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, minY);
        }

        else if (transform.position.y < minY)
        {
            transform.position = new Vector2(transform.position.y, maxY);
        }
    }
}
