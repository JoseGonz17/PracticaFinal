using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public static PointsCounter instance;
    public Text pointsText;
    public float point = 1;
    public float pointsCurrents;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        pointsCurrents = point;
    }

    private void Update()
    {
        if (gameObject.CompareTag("Duck") && Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointsText.text = pointsCurrents.ToString();
            pointsCurrents += point;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Duck") && Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointsText.text = pointsCurrents.ToString();
            pointsCurrents += point;
        }
    }
}