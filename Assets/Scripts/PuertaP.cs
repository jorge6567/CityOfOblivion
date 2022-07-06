using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject nokey;
    public GameObject key;
    public GameObject BtnPuerta;


    void Start()
    {
        key.SetActive(false);

        nokey.SetActive(false);

        BtnPuerta.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("key"))
        {
            LLavePrinicipa.llave += 1;
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Door") && LLavePrinicipa.llave == 0)
        {
            nokey.SetActive(true);
        }
        if (collision.tag.Equals("Door") && LLavePrinicipa.llave == 1)
        {
            key.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    void Update()
    {
        
    }
}
