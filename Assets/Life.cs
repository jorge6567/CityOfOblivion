using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float PuntosJugador;
    public float VidaJugador = 1;
    void Start()
    {
        PuntosJugador = VidaJugador;
    }

    public void TakeHit(float damage)
    {
        PuntosJugador -= damage;
        if (PuntosJugador <= 0)
        {
            PlayerManager.isGameOver = true;
            Destroy(gameObject);
        }
    }

}
