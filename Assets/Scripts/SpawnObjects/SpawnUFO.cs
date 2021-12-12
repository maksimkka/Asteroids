using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class SpawnUFO : Spawner<Ufo>
//public class SpawnUFO : Spawner
public class SpawnUFO : SpawnerObject
{
    protected override void Start()
    {
        StartCoroutine(SpawnEnemy(Quaternion.identity));
    }

    protected override void Repeat()
    {
        StartCoroutine(SpawnEnemy(Quaternion.identity));
    }

    //protected override IEnumerator SpawnEnemy(Quaternion quaternion)
    //{
    //    yield return new WaitForSeconds(Random.Range(minSpawnTime, minSpawnTime));
    //    Randomizer(enemy, spawners);
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

    //    Repeat(quaternion);
    //}

}
