using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int scoreCount;
    [SerializeField] protected ParticleSystem boomParticle;
    protected Score score;

    protected virtual void Start()
    {
        score = FindObjectOfType<Score>();
        transform.Rotate(new Vector3(0, 0, Random.Range(-45f, 45f)));
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }

    public virtual void Dead()
    {
        boomParticle.transform.position = new Vector2(transform.position.x, transform.position.y);
        Instantiate(boomParticle);
        score.IncreaseScore(scoreCount);
        Destroy(gameObject);
    }
}
