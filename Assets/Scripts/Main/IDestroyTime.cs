using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestroyAfterTimer
{
    public IEnumerator DestroyAfterTime(float timeToDestruction, GameObject gameObject);
}
