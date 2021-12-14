using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeed
{
    private float moveSpeed;
    private float maxSpeed;
    private float scaledMoveSpeed;

    public PlayerSpeed(float moveSpeed, float maxSpeed)
    {
        this.moveSpeed = moveSpeed;
        this.maxSpeed = maxSpeed;
    }

    public float IncreaseSpeed(float moveForvard)
    {
        if (moveForvard > 0 && scaledMoveSpeed < maxSpeed)
        {
            scaledMoveSpeed += Time.deltaTime * moveSpeed;

            if (scaledMoveSpeed > maxSpeed)
            {
                scaledMoveSpeed = maxSpeed;
            }
        }

        else if (moveForvard == 0 && scaledMoveSpeed > 0)
        {
            scaledMoveSpeed -= Time.deltaTime;
            if (scaledMoveSpeed < 0)
            {
                scaledMoveSpeed = 0;
            }
        }

        return scaledMoveSpeed;
    }
}
