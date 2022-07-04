using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public TMPro.TextMeshProUGUI textoContBalas;

    private Animator anim; 

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    int Municion = 20;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Municion > 0)
            {
                Shoot();
                anim.Play("HGDisparo");
            }
            else
            {
                Debug.Log("No tiene balas");
            }
        }

        textoContBalas.text = Municion.ToString();
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Municion -= 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Municion"))
        {
            Destroy(collision.gameObject);
            Municion += 5;
            anim.Play("HGReload");
        }
    }
}
