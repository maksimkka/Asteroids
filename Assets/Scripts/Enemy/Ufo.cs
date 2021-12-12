using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo : Enemy
{
    private Transform target;

    protected override void Start()
    {
        score = FindObjectOfType<Score>();
        target = FindObjectOfType<PlayerController>().GetComponent<Transform>();
    }

    protected override void Move()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
