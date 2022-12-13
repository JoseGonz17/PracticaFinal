using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : PlayerTrigger
{
    public int damageAmount = 1;

    public override void OnPlayerEnter2D(GameObject playerObject)
    {
        Health health = GetComponent<Health>();
        health.TakeDamage(damageAmount);
    }
}