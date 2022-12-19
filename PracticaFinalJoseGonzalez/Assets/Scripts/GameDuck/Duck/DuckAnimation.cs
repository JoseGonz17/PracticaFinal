using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAnimation : MonoBehaviour
{
    public Animator DoorAnimator;

    public AudioSource duckAudio;

    private bool duckDie = true;

    private void Start()
    {
        duckAudio = GetComponent<AudioSource>();    
    }

    public void OnMouseDown()
    {
        DoorAnimator.SetBool("Die", duckDie);
        duckDie = !duckDie;
        duckAudio.Play();
    }
}