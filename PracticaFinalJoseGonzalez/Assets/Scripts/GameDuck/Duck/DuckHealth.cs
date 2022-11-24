using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckHealth : MonoBehaviour
{
    public float currentHealth;
    private float maxHealth = 1;

    private string duckTag = "Duck";

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        gameObject.CompareTag(duckTag);
    }
}