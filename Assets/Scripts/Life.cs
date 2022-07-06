using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject cam;
    public GameObject Enemigos;
    public float PuntosJugador;
    public float VidaJugador = 1;
    [SerializeField] private GameObject Sangre;
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
            Sangre.SetActive(true);
            StartCoroutine(EsperarAtaquePJ(1f));
            gameObject.GetComponent<Shooting>().enabled = false;
            gameObject.GetComponent<Movimiento>().enabled = false;
            cam.GetComponent<CamaraController>().enabled = false;
            Enemigos.GetComponent<IA_Movimiento>().enabled = false;
            Enemigos.GetComponent<FollowPlayer>().enabled = false;
        }
    }
    IEnumerator EsperarAtaquePJ(float time)
    {
        yield return new WaitForSeconds(0.8f);
        PlayerManager.isGameOver = true;
    }
}
