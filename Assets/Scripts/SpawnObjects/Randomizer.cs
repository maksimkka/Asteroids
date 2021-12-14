using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : IRandomizer
{
    private int maxIndex;
    private Transform[] spawnersPositions;
    
    public int indexSpawnObject;
    public int indexSpawner;

    public Randomizer(int maxIndex, Transform[] spawnersPositions)
    {
        this.maxIndex = maxIndex;
        this.spawnersPositions = spawnersPositions;
    }

    public Vector3 RandomizeVector(int position)
    {
        
        bool isVertical = spawnersPositions[position].transform.localScale.x > 10;

        if (isVertical)
        {
            float maxX = spawnersPositions[position].transform.position.x + spawnersPositions[position].transform.localScale.x / 2;
            float minX = spawnersPositions[position].transform.position.x - spawnersPositions[position].transform.localScale.x / 2;

            return new Vector3(Random.Range(minX, maxX), spawnersPositions[position].transform.position.y);
        }

        else
        {
            float maxY = spawnersPositions[position].transform.position.y + spawnersPositions[position].transform.localScale.x / 2;
            float minY = spawnersPositions[position].transform.position.y - spawnersPositions[position].transform.localScale.x / 2;

            return new Vector3(spawnersPositions[position].transform.position.x, Random.Range(minY, maxY));
        }
    }

    public int RandomizeIndex()
    {
        return Random.Range(0, maxIndex);
    }

    public int RandomizePosition()
    {
        return Random.Range(0, spawnersPositions.Length);
    }
}
