using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    void Update()
    {
        Destroy(gameObject, 3f);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var enemigo = collision.collider.GetComponent<VidaEnemigo>();
        if(enemigo)
        {
            enemigo.TakeHit(1);
        }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.2f);
        Destroy(gameObject);
    }
}
