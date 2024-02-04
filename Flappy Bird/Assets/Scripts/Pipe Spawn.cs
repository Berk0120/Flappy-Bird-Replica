using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;

    public float minY;

    public float maxY;

    public float x;

    public float interval;

    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

   private void spawn()
    {
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
        instance.transform.SetParent(transform);
    }
}
