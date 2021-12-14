using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTimer : MonoBehaviour, IDestroyAfterTimer
{
    public IEnumerator DestroyAfterTime(float timeToDestruction, GameObject gameObject)
    {
        yield return new WaitForSeconds(timeToDestruction);
        Destroy(gameObject);
    }
}