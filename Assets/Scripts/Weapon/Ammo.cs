using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int timeToDestruction;
    [SerializeField] protected AmmoType ammoType;
    //protected BigAsteroid bigAsteroid;
    //protected SmallAsteroid smallAsteroid;
    protected IDestroyTime destroyTime;
    //protected Ufo ufo;
    private HitHandler hitHandler = new HitHandler();


    protected void Start()
    {
        destroyTime = gameObject.AddComponent<DestroyGameObject>();
        StartCoroutine(destroyTime.DestroyAfterTime(timeToDestruction, gameObject));
        //Invoke(nameof(DestroyAmmo), timeToDestruction);
    }

    protected void Update()
    {
        MoveAmmo();
    }

    protected void MoveAmmo()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    //protected void DestroyAmmo()
    //{
    //    Destroy(gameObject);
    //}

    //protected void GetObject(Collider2D collision)
    //{
    //    bigAsteroid = collision.GetComponent<BigAsteroid>();
    //    smallAsteroid = collision.GetComponent<SmallAsteroid>();
    //    ufo = collision.GetComponent<Ufo>();
    //}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && AmmoType.Bomb == ammoType)
        {
            hitHandler.Hit(ammoType, collision);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Enemy") && AmmoType.Laser == ammoType)
        {
            hitHandler.Hit(ammoType, collision);
            
        }

        //Destroy(gameObject);
    }
}
