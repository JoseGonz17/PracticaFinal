using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    public Transform[] startPosition;
    public Transform[] standByPosition;
    public Transform[] endPosition;

    public GameObject duckFirstMove;
    private float duckStandByPosition;
    private float duckStartPosition;

    private void Start()
    {
    }

    public void RespawnRandomPosition()
    {
        duckFirstMove.transform.position = new Vector3(0, Random.Range(duckStartPosition, duckStandByPosition), 0);
    }
}