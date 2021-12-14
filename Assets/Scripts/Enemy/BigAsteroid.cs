using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAsteroid : Enemy
{
    [SerializeField] private GameObject smallAsteroid;

    public void CreateSmaalAsteroid()
    {
        Instantiate(smallAsteroid, gameObject.transform.position, Quaternion.identity);
        Instantiate(smallAsteroid, gameObject.transform.position, Quaternion.identity);
    }
}
