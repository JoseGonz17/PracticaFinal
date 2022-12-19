using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text pointsText;
    public float point;

    private void Update()
    {
        //pointsText.text = point.ToString();
    }
    public void GetPoint()
    {
        point += 1;
    }


}