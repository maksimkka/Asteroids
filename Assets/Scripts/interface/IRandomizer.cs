using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRandomizer
{
    //public int IndexSpawnObject { get; set; }
    //public int IndexSpawner { get; set; }
    public int RandomizeIndexSpawner(Transform[] spawnersPosition);
    public int RandomizeIndexObject(GameObject[] spawnObject);
    public void Randomize(GameObject[] spawnObject, Transform[] spawners);
    public Vector3 RandomizePosX(Transform[] spawnersPosition);
    public Vector3 RandomizePosY(Transform[] spawnersPosition);

}
