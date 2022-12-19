using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

public class Point : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Duck")
        {
            other.gameObject.GetComponent<PointsCounter>().GetPoint();
            Destroy(gameObject);
        }
    }
=======
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class Point : MonoBehaviour
{

>>>>>>> Stashed changes
}