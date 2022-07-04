using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject GameOverScreen;
    private float a;
    public GameObject player;

    private void Awake()  
    {
        isGameOver = false;
    }

    void Update()
    {
        StartCoroutine(Esperar(1f));
        if (isGameOver && a == 1)
        {
            GameOverScreen.SetActive(true);
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void CambiarAnimator()
    {

    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
    IEnumerator Esperar(float time)
    {
        yield return new WaitForSeconds(1f);
        a = 1;
    }
}

