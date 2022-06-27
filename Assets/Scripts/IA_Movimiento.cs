using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Movimiento : MonoBehaviour
{
    public SpriteRenderer PersonajeEnemigo;
    public float speed = 1.2f; //Velocidad de Movimiento
    private float waitTime; //Variable de apoyo calculo de tiempo
    public float startWaitTime = 2; //Tiempo de Espera que se pone manualmente
    public Transform[] moveSpots; //Matriz de posiciones
    private int i = 0; //Control de posiciones
    private Vector2 actualPos;

    void Start()
    {
        waitTime = startWaitTime;
    }

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);
        //Que hacer cuando llega a una posicion
        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0) //Tiempo de espera
            {
                //COntador de posiciones
                if (moveSpots[i] != moveSpots[moveSpots.Length - 1]) //Revisa si hay mas puntos para visitar
                {
                    i++; // si hay aumentamos una ruta
                }
                else
                {
                    i = 0; //si no pues cambia al primer valor
                }

                waitTime = startWaitTime;

            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
    }
}
