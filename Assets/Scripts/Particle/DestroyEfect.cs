using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEfect : MonoBehaviour
{
    [SerializeField] private int timeToDestruction;

    //private DestroyGameObject destroyGameObject;
    private IDestroyTime destroyTime;

    private void Start()
    {
        //FindObjectOfType<DestroyGameObject>();
        //destroyGameObject = FindObjectOfType<DestroyGameObject>().GetComponent<DestroyGameObject>();
        //destroyGameObject = new DestroyGameObject();
        //destroyGameObject = gameObject.AddComponent<DestroyGameObject>();
        destroyTime = gameObject.AddComponent<DestroyGameObject>();
        //destroyTime = new IDestroyTime();
        //destroyTime = GetComponent<IDestroyTime>();
        //destroyGameObject = new DestroyGameObject(destroyTimer);
        StartCoroutine(destroyTime.DestroyAfterTime(timeToDestruction, gameObject));
        //destroyTime.DestroyAfterTime(destroyTimer, gameObject);
    }


    private void FixedUpdate()
    {
        //destroyGameObject.DestroyAfterTime(destroyTimer, gameObject);
        //destroyTime.DestroyAfterTime(destroyTimer, gameObject);
        
    }
}
