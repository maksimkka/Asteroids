using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed;
    //[SerializeField] protected float destroyTime;
    [SerializeField] protected int scoreCount;
    [SerializeField] protected ParticleSystem boomParticle;
    protected Score score;
    
    protected virtual void Start()
    {
        score = FindObjectOfType<Score>();
        //Invoke(nameof(Dead), destroyTime);
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
        //boomParticle.Play();
        Instantiate(boomParticle);
        
        score.IncreaseScore(scoreCount);
        Destroy(gameObject);
    }

    //public void TakeLaserDamage()
    //{
    //    Dead();
    //}

    //public virtual void TakeBombDamage()
    //{
    //    Dead();
    //}
}
