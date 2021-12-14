using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatableTimer : MonoBehaviour
{
    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    public delegate void CallBack();
    private CallBack onRepeat;

    private void Start()
    {
        StartCoroutine(Repeat());
    }

    private IEnumerator Repeat()
    {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        onRepeat();
        StartCoroutine(Repeat());
    }

    public void SetOnRepeat(CallBack onRepeat)
    {
        this.onRepeat = onRepeat;
    }
}
