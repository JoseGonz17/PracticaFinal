using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public float speed = 7;

    public Transform standbyPosition;

    // Update is called once per frame
    private void Update()
    {
        float change = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, standbyPosition.transform.position, change);
    }
}