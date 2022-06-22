using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject player; //Variable que sigue al jugador
    //limites camara
    public bool limites;  //Activar y desactivar limites de movimiento camara
    public Vector2 minCameraPos;
    public Vector2 maxCameraPos;



    void FixedUpdate() //Para que los comando se ejecuten en cada frame
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        //como no es juego 3d no tienen seguimiento en 0
        if (limites)
        {
            transform.position = new Vector3
                (
                Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
                Mathf.Clamp(-10, -10, -10)
                );
        }
    }
}
