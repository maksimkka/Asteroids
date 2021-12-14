using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEfect : MonoBehaviour
{
    [SerializeField] private int timeToDestruction;

    private IDestroyAfterTimer destroyTime;

    private void Start()
    {
        destroyTime = gameObject.AddComponent<DestroyAfterTimer>();
        StartCoroutine(destroyTime.DestroyAfterTime(timeToDestruction, gameObject));
    }
}
