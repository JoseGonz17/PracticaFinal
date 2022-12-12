using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image health;
    public float currentHealth = 0;
    public float maxHealth = 5;

    private void Start()
    {
        currentHealth = maxHealth;
        health.fillAmount = Mathf.InverseLerp(0, maxHealth, currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth -= 1;
        }
    }
}