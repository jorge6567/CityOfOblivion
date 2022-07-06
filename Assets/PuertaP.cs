using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaP : MonoBehaviour
{
    public GameObject nokey;
    public GameObject key;
    public GameObject BtnPuerta;
    public GameObject Pue;


    void Start()
    {
        key.SetActive(false);

        nokey.SetActive(false);

        BtnPuerta.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("key"))
        {
            LLavePrinicipa.llave += 1;
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("door") && LLavePrinicipa.llave == 0)
        {
            nokey.SetActive(true);
        }
        if (collision.tag.Equals("door") && LLavePrinicipa.llave == 1)
        {
            key.SetActive(true);
            BtnPuerta.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("door") && LLavePrinicipa.llave == 0)
        {
            nokey.SetActive(false);
        }
        if (collision.tag.Equals("door") && LLavePrinicipa.llave == 1)
        {
            key.SetActive(false);
            BtnPuerta.SetActive(false);
        }
    }

    public void botonabroP()
    {
        Destroy(Pue);
    }

    void Update()
    {

    }
}
