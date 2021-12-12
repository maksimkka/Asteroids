using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public abstract class Spawner<T> : MonoBehaviour where GameObject : MonoBehaviour
public abstract class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T[] spawnObject;
    [SerializeField] protected Transform[] spawnersPosition;

    [SerializeField] protected float minSpawnTime;
    [SerializeField] protected float maxSpawnTime;

    protected float maxX;
    protected float minX;
    protected float maxY;
    protected float minY;
    protected int indexSpawnObject;
    protected int indexSpawner;
    //protected IRandomizer randomizer;


    protected void Randomize(T[] spawnObject, Transform[] spawners)
    {
        indexSpawnObject = Random.Range(0, spawnObject.Length);
        indexSpawner = Random.Range(0, spawners.Length);
        if (spawners[indexSpawner].transform.localScale.x > 10)
        {
            maxX = spawners[indexSpawner].transform.position.x + spawners[indexSpawner].transform.localScale.x / 2;
            minX = spawners[indexSpawner].transform.position.x - spawners[indexSpawner].transform.localScale.x / 2;
        }

        else
        {
            maxY = spawners[indexSpawner].transform.position.y + spawners[indexSpawner].transform.localScale.x / 2;
            minY = spawners[indexSpawner].transform.position.y - spawners[indexSpawner].transform.localScale.x / 2;
        }
    }

    protected virtual void Start()
    {
        //randomizer = gameObject.AddComponent<Randomizer>();
        //indexSpawnObject = randomizer.IndexSpawnObject;
        //indexSpawner = randomizer.IndexSpawner;
        StartCoroutine(SpawnEnemy(spawnersPosition[indexSpawner].transform.rotation));
    }

    protected virtual void Repeat()
    {
        StartCoroutine(SpawnEnemy(spawnersPosition[indexSpawner].transform.rotation));
    }

    protected virtual IEnumerator SpawnEnemy(Quaternion quaternion)
    {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));

        //indexSpawnObject = randomizer.IndexSpawnObject;
        //indexSpawner = randomizer.IndexSpawner;
        //indexSpawnObject = randomizer.RandomizeIndexObject(spawnObject);
        //indexSpawner = randomizer.RandomizeIndexSpawner(spawnersPosition);
        //randomizer.Randomize(spawnObject, spawnersPosition);
        //indexSpawner = Random.Range(0, spawnersPosition.Length);
        //indexSpawnObject = Random.Range(0, spawnObject.Length);
        Randomize(spawnObject, spawnersPosition);

        if (spawnersPosition[indexSpawner].transform.localScale.x > 10)
        {
            Vector3 spawnerPosX = new Vector3(Random.Range(minX, maxX), spawnersPosition[indexSpawner].transform.position.y);
            //Vector3 spawnerPosX = randomizer.RandomizePosX(spawnersPosition);
            Instantiate(spawnObject[indexSpawnObject], spawnerPosX, quaternion);
        }

        else
        {
            Vector3 spawnerPosY = new Vector3(spawnersPosition[indexSpawner].transform.position.x, Random.Range(minY, maxY));
            //Vector3 spawnerPosY = randomizer.RandomizePosY(spawnersPosition);
            Instantiate(spawnObject[indexSpawnObject], spawnerPosY, quaternion);
        }

        Repeat();
    }

    //protected virtual void Start()
    //{
    //    StartCoroutine(SpawnEnemy(spawners[randomSpawner].transform.rotation));
    //}

    //protected virtual void Repeat()
    //{
    //    StartCoroutine(SpawnEnemy(spawners[randomSpawner].transform.rotation));
    //}

    //protected virtual IEnumerator SpawnEnemy(Quaternion quaternion)
    //{
    //    yield return new WaitForSeconds(Random.Range(minSpawnTime, minSpawnTime));
    //    Randomizer(enemy, spawners);
    //    //Debug.Log("SPAWNER" + randomSpawner);
    //    //Debug.Log("OBJECT " +randomEnemy);
    //    if (spawners[randomSpawner].transform.localScale.x > 10)
    //    {
    //        Vector3 spawnerPos = new Vector3(Random.Range(minX, maxX), spawners[randomSpawner].transform.position.y);
    //        Instantiate(enemy[randomEnemy], spawnerPos, quaternion);
    //    }

    //    else
    //    {
    //        Vector3 spawnerPos = new Vector3(spawners[randomSpawner].transform.position.x, Random.Range(minY, maxY));
    //        Instantiate(enemy[randomEnemy], spawnerPos, quaternion);
    //    }

    //    Repeat();
    //}
}
