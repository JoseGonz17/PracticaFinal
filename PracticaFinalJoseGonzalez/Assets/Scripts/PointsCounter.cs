using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text pointsText;
    public float currentNumberOfPoints = 0;

    public void GetPoint(int pointAmount)
    {
        currentNumberOfPoints += pointAmount;

        if (pointsText != null)
        {
            pointsText.text = currentNumberOfPoints.ToString();
        }
        Debug.Log("he recogido una moneda, tengo: " + currentNumberOfPoints + "monedas");
    }
}