using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public float tiempo_start; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    public float tiempo_end; //Segundos que queremos que pasen para que cambie de escena
                             // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;//Funci�n para que la variable tiempo_start vaya contando segundos.
        if (tiempo_start >= tiempo_end) //Si pasan los segundos que hemos puesto antes...
        {
           SceneManager.LoadScene("Game");
        }
    }
}
