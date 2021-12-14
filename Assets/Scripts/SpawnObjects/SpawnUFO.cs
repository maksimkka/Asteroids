using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUFO : Spawner<Ufo>
{
    protected override Quaternion GetQuartenion()
    {
        return Quaternion.identity;
    }
}
