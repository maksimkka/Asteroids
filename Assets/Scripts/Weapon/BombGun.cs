using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGun : Weapon
{
    protected override void Awake()
    {
        input = new PlayerInput();
        input.Player.BombShot.performed += context => Shot();
    }

    protected override void Shot()
    {
        if (!StartGame.isStarted) return;

        if (timeShot <= 0)
        {
            Instantiate(ammo, shotDir.position, transform.rotation);
            timeShot = startTime;
        }
    }

    protected override void Update()
    {
        TimerShot();
    }
}
