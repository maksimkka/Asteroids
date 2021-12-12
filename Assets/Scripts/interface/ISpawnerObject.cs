using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnerObject 
{
   
    public IEnumerator Spawn(Quaternion quaternion);
}
