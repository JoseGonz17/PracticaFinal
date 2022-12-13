using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string playerTag = "Player";

    public virtual void OnPlayerEnter2D(GameObject playerObject)
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter2D(other.gameObject);
        }
    }
}