using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserGun : Weapon
{
    [SerializeField] private Text countLaserText;
    [SerializeField] private Text cooldownText;
    [SerializeField] private int currentLaser;
    [SerializeField] private int maxLaser;
    [SerializeField] private float laserCooldown;
    private float laserCooldownTime;

    protected override void Awake()
    {
        input = new PlayerInput();
        input.Player.LaserShot.performed += context => Shot();
    }

    protected void Cooldown(int current)
    {
        if (current < maxLaser && laserCooldownTime > 0)
        {
            laserCooldownTime -= Time.deltaTime;
            if (laserCooldownTime <= 0)
            {
                currentLaser++;
                laserCooldownTime = laserCooldown;
            }
        }
    }

    protected override void Shot()
    {
        if (!StartGame.isStarted) return;
        if (timeShot > 0) return;

        if (currentLaser > 0 && currentLaser <= maxLaser)
        {
            Instantiate(ammo, shotDir.position, transform.rotation);
            timeShot = startTime;
            currentLaser--;
        }
    }

    protected void Start()
    {
        laserCooldownTime = laserCooldown;
    }

    protected void LaserText()
    {
        countLaserText.text = $"{currentLaser}/{maxLaser}";
        cooldownText.text = $"{timeShot}";
    }

    protected override void Update()
    {
        Cooldown(currentLaser);
        TimerShot();
        LaserText();
    }
}
