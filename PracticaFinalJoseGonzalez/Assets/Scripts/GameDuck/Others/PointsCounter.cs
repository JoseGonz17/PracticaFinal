using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public int currentNumberOfCoins;

    public Text pointText;

    public void GetCoins(int cointAmount)
    {
        currentNumberOfCoins += cointAmount;

        if (pointText != null)
        {
            pointText.text = currentNumberOfCoins.ToString();
        }

        Debug.Log("he cazado un pato,llevo: " + currentNumberOfCoins + "cazados");
    }
}