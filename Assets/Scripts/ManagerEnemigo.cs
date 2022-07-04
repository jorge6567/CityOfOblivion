using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemigo : MonoBehaviour
{
    public float PuntosVida;
    public float VidaMaxima = 5;
    private Animator anim;
    private float Antes;
    public GameObject pj;
    private Rigidbody2D rb;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        PuntosVida = VidaMaxima;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    public void Die()
    {
        Destroy(gameObject);
    }
    public void TakeHit(float damage)
    {
        PuntosVida -= damage;   
        //(if(gameObject.layer == Zombie) Hacer un sistema para cambiar de animacion mediante menos vida tenga el zombie como si se le estuviera saliendo las partes del cuerpo
        //{
        //    if (PuntosVida >= 2)
        //}    

        if (PuntosVida <= 0)
        {
            int Slime = LayerMask.NameToLayer("Slime");
            int Wolf = LayerMask.NameToLayer("Wolf");
            int Zombie = LayerMask.NameToLayer("Zombie");

            if (gameObject.layer == Slime)
            {
                anim.Play("muerteS");
            }
            if (gameObject.layer == Zombie)
            {
                Debug.Log("Zombie");
            }
            if (gameObject.layer == Wolf)
            {
                anim.Play("muerte");
            }
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(EsperarDañoPersonaje(1f));
            gameObject.GetComponent<FollowPlayer>().enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player1")
        {
            int Slime = LayerMask.NameToLayer("Slime");
            int Wolf = LayerMask.NameToLayer("Wolf");
            int Zombie = LayerMask.NameToLayer("Zombie");
            if (gameObject.layer == Slime)
            {
                Debug.Log("SlimeA");
            }
            if (gameObject.layer == Zombie)
            {
                Debug.Log("ZombieA");
            }
            if (gameObject.layer == Wolf)
            {
                anim.Play("AtaqueW");
            }
        }
        var player = collision.collider.GetComponent<Life>();
        if (player)
        {
            gameObject.GetComponent<FollowPlayer>().enabled = false;
            gameObject.GetComponent<IA_Movimiento>().enabled = false;
            player.TakeHit(1);
            gameObject.GetComponent<ManagerEnemigo>().enabled = false;
        }
    }
    IEnumerator EsperarDañoPersonaje(float time)
    {
        yield return new WaitForSeconds(0.8f);
        Antes = 1;
        if (Antes == 1)
        {
            Destroy(gameObject);
        }
    }
}
