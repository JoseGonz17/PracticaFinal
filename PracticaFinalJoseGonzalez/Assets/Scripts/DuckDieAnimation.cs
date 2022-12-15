using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckDieAnimation : MonoBehaviour
{
    public Animator dieAnimator;

    private bool duckDie = true;

    public void DuckDie()
    {
        dieAnimator.SetBool("Die", duckDie);
        duckDie = !duckDie;
    }
}