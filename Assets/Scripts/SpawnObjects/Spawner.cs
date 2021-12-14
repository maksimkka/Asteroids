using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T[] spawnObjects;
    [SerializeField] protected Transform[] spawnersPositions;
    [SerializeField] private RepeatableTimer repeatableTimer;

    protected IRandomizer randomizer;

    protected int spawnCurrentPosition;

    private void Start()
    {
        randomizer = new Randomizer(spawnObjects.Length, spawnersPositions);
        repeatableTimer.SetOnRepeat(SpawnEnemy);
    }

    protected void SpawnEnemy()
    {
        spawnCurrentPosition = randomizer.RandomizePosition();
        Instantiate(spawnObjects[randomizer.RandomizeIndex()], randomizer.RandomizeVector(spawnCurrentPosition), GetQuartenion());
    }

    protected abstract Quaternion GetQuartenion();
}
