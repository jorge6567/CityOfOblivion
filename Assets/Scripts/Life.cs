using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject cam;
    public GameObject Enemigos;
    public float PuntosJugador;
    public float VidaJugador = 1;
    public void Start()
    {
        PuntosJugador = VidaJugador;
        Enemigos = GameObject.FindGameObjectWithTag("Enemies");
    }

    public void TakeHit(float damage)
    {
        PuntosJugador -= damage;
        if (PuntosJugador <= 0)
        {
            PlayerManager.isGameOver = true;    
            gameObject.GetComponent<Shooting>().enabled = false;
            gameObject.GetComponent<Movimiento>().enabled = false;
            cam.GetComponent<CamaraController>().enabled = false;
            Enemigos.GetComponent<IA_Movimiento>().enabled = false;
            Enemigos.GetComponent<FollowPlayer>().enabled = false;
        }
    }

}
