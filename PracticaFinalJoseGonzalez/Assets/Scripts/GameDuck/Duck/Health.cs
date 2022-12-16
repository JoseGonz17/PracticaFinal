using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : PlayerTrigger
{
    public Image healthBar;

    public float currentHealth;
    public float maxHealth = 5;

    private void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
    public void TakeDamage(int damageTaken) 
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("me han echo daño, salud restante " + currentHealth);
        }
    }

}