using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public int currentPoints = 0;

    public static PointManager instance;

    public Text scoretext;

    private void Start()
    {
        instance = this;
    }

    public void Addpoints(int poinstoAdd)
    {
        currentPoints += poinstoAdd;
        scoretext.text = currentPoints.ToString();
    }
}