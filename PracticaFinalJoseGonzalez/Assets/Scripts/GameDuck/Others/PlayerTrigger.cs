using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string playerTag = "Player";

    public virtual void OnPlayerCollision2D(GameObject playerObject)
    {
    }

    private void OnTriggerCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerCollision2D(other.gameObject);
        }
    }
}