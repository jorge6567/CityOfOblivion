using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        var player = collision.collider.GetComponent<Life>();
        if (player)
        {
            player.TakeHit(1);
        }
    }
}
