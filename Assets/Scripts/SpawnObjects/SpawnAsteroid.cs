using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : Spawner<BigAsteroid>
{
    protected override Quaternion GetQuartenion()
    {
        return spawnersPositions[spawnCurrentPosition].transform.rotation;
    }
}
