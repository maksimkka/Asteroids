using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHandler
{

    public void Hit(AmmoType ammoType, Collider2D collision)
    {
        BigAsteroid bigAsteroid = collision.GetComponent<BigAsteroid>();
        SmallAsteroid smallAsteroid = collision.GetComponent<SmallAsteroid>();
        Ufo ufo = collision.GetComponent<Ufo>();

        switch (ammoType)
        {
            case AmmoType.Bomb:
                HitBigAsteroid(bigAsteroid);
                HitSmaalAsteroid(smallAsteroid);
                HitUfo(ufo);
                break;

            case AmmoType.Laser:
                if (bigAsteroid != null)
                {
                    bigAsteroid.Dead();
                }

                HitSmaalAsteroid(smallAsteroid);
                HitUfo(ufo);
                break;
        }

        //return collision;
    }

    private void HitBigAsteroid(BigAsteroid bigAsteroid)
    {
        if (bigAsteroid != null)
        {
            bigAsteroid.Dead();
            bigAsteroid.CreateSmaalAsteroid();
        }
    }

    private void HitSmaalAsteroid(SmallAsteroid smallAsteroid)
    {
        if (smallAsteroid != null)
        {
            smallAsteroid.Dead();
        }
    }

    private void HitUfo(Ufo ufo)
    {
        if (ufo != null)
        {
            ufo.Dead();
        }
    }
}
