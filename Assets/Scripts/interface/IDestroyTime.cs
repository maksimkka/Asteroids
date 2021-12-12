using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestroyTime
{
    //public void DestroyAfterTime(int destroyTime, GameObject gameObject);
    public IEnumerator DestroyAfterTime(int timeToDestruction, GameObject gameObject);
}
