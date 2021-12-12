using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour, IRandomizer
{
    private float maxX;
    private float minX;
    private float maxY;
    private float minY;
    //public int IndexSpawnObject { get; set; }
    //public int IndexSpawner { get; set; }
    public int indexSpawnObject;
    public int indexSpawner;

    public void Randomize(GameObject[] spawnObject, Transform[] spawnersPosition)
    {
        //float temp;
        //indexSpawnObject = Random.Range(0, spawnObject.Length);

        //indexSpawner = Random.Range(0, spawnersPosition.Length);
        //indexSpawnObject = ();
        //indexSpawner = RandomizeIndexObject(spawnObject);
        if (spawnersPosition[indexSpawner].transform.localScale.x > 10)
        {
            maxX = spawnersPosition[indexSpawner].transform.position.x + spawnersPosition[indexSpawner].transform.localScale.x / 2;
            minX = spawnersPosition[indexSpawner].transform.position.x - spawnersPosition[indexSpawner].transform.localScale.x / 2;
        }

        else
        {
            maxY = spawnersPosition[indexSpawner].transform.position.y + spawnersPosition[indexSpawner].transform.localScale.x / 2;
            minY = spawnersPosition[indexSpawner].transform.position.y - spawnersPosition[indexSpawner].transform.localScale.x / 2;
        }

        //return temp;
    }

    public Vector3 RandomizePosX(Transform[] spawnersPosition)
    {
        //return new Vector3(Random.Range(-maxX, maxX), spawnersPosition[indexSpawner].transform.position.y);
        return new Vector3(Random.Range(-maxX, maxX), spawnersPosition[indexSpawner].transform.position.y);

        //Vector3 spawnerPosY = new Vector3(spawnersPosition[indexSpawner].transform.position.x, Random.Range(minY, maxY));
    }

    public Vector3 RandomizePosY(Transform[] spawnersPosition)
    {
       return new Vector3(spawnersPosition[indexSpawner].transform.position.x, Random.Range(-maxY, maxY));
    }

    public int RandomizeIndexObject(GameObject[] spawnObject)
    {
        return Random.Range(0, spawnObject.Length);
    }

    public int RandomizeIndexSpawner(Transform[] spawnersPosition)
    {
        return Random.Range(0, spawnersPosition.Length);
    }

}
