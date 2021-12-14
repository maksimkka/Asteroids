using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject ammo;
    [SerializeField] protected Transform shotDir;
    [SerializeField] protected float startTime;

    protected PlayerInput input;
    protected float timeShot;

    protected abstract void Awake();
    protected abstract void Update();
    protected abstract void Shot();

    protected void OnEnable()
    {
        input.Enable();
    }

    protected void OnDisable()
    {
        input.Disable();
    }

    protected void TimerShot()
    {
        if(timeShot >= 0)
        {
            timeShot -= Time.deltaTime;
            if (timeShot <= 0)
            {
                timeShot = 0;
            }
        }
    }
}
