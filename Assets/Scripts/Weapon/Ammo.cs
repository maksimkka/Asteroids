using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ammo : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float timeToDestruction;
    [SerializeField] protected AmmoType ammoType;

    private IDestroyAfterTimer destroyTime;
    private HitHandler hitHandler = new HitHandler();

    protected void Start()
    {
        destroyTime = gameObject.AddComponent<DestroyAfterTimer>();
        StartCoroutine(destroyTime.DestroyAfterTime(timeToDestruction, gameObject));
    }

    protected void Update()
    {
        MoveAmmo();
    }

    protected void MoveAmmo()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

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
    }
}
