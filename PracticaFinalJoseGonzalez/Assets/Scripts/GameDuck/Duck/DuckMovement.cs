using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    public Transform[] startPosition;

    //public Transform[] endPosition;

    public GameObject duckPrefab;

    private float timeToSpawn = 1f;
    private float timeSinceLastSpawn;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > timeToSpawn)
        {
            timeSinceLastSpawn = 0;
            int rand = Random.Range(0, startPosition.Length);
            Transform randonPos = startPosition[rand];
            Instantiate(duckPrefab, randonPos.position, Quaternion.identity);
        }
    }
}