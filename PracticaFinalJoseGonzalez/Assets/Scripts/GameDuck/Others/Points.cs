using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : PlayerTrigger
{
    public int amountToGive = 1;

    private MeshRenderer duckMesh;

    private Collider duckCollider;

    private void Start()
    {
        duckMesh = GetComponentInChildren<MeshRenderer>();
        duckCollider = GetComponentInChildren<Collider>();
    }

    public void OnPlayerClick(GameObject playerObject)
    {
        PointsCounter counter = playerObject.GetComponent<PointsCounter>();
        counter.GetCoins(amountToGive);

        duckMesh.enabled = false;
        duckCollider.enabled = false;
    }
}