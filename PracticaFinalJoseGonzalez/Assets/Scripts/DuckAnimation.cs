using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAnimation : MonoBehaviour
{
    public Animator DoorAnimator;

    private bool duckDie = true;

    public void OnMouseDown()
    {
        DoorAnimator.SetBool("Die", duckDie);
        duckDie = !duckDie;
    }
}