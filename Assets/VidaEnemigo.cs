using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float PuntosVida;
    public float VidaMaxima = 5;
    void Start()
    {
        PuntosVida = VidaMaxima;
    }

    public void TakeHit(float damage)
    {
        PuntosVida -= damage;
        if(PuntosVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
