using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int amountToGive;

    public void OnMouseDown()
    {
        Destroy(gameObject);
    }

    public void PointsToGive(GameObject point)
    {
        if (gameObject == null)
        {
            PointsCounter counter = point.GetComponent<PointsCounter>();
            counter.GetPoint(amountToGive);
            Debug.Log("a");
        }
    }
}