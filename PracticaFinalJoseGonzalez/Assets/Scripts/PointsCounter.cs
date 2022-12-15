using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text pointsText;
    public float point;

    public void GetPoint()
    {
        point += 1;
    }

    private void Update()
    {
        pointsText.text = point.ToString();
    }
}