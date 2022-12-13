using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image health;
    public float currentHealth = 0;
    public float maxHealth = 5;

    private void Start()
    {
        currentHealth = maxHealth;
        HealthImage();
    }

    public void TakeDamage(int damageTaken)
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("me han echo daño, salud restante " + currentHealth);
        }
        HealthImage();
    }

    public void HealthImage()
    {
        health.fillAmount = Mathf.InverseLerp(0, maxHealth, currentHealth);
    }
}