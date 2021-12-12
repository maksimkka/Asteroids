using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour, IDestroyTime
{
    //private int destroyTimer;

    //public DestroyGameObject(float destroyTime)
    //{
    //    this.destroyTime = destroyTime;
    //}

    //public void DestroyAfterTime(int destroyTime, GameObject gameObjects)
    //{
        //destroyTime = Timer(destroyTime);
        //Timer(destroyTime);
        //if (Timer(destroyTime) <= 0)
        //if(destroyTime <= 0)
        //{

        //StartCoroutine(Timers(destroyTime, gameObject));
        //Destroy(gameObjects);
        //}
        // Debug.Log(destroyTime);
        //Invoke(nameof(DestroyObject), destroyTime);
        
    //}

    //private void DestroyObject(GameObject gameObject)
    //{
    //    Destroy(gameObject);
    //}

    public IEnumerator DestroyAfterTime(int timeToDestruction, GameObject gameObject)
    {
        yield return new WaitForSeconds(timeToDestruction);
        Destroy(gameObject);
    }

    //private float Timer(float destroyTime)
    //{
    //    if(destroyTime > 0)
    //    {
    //        destroyTime -= Time.deltaTime;
    //    }

    //    else if(destroyTime <= 0)
    //    {
    //        destroyTime = 0;
    //    }

    //    return destroyTime;
    //}
}
