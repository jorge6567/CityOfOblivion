using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject GameOverScreen;

    private void Awake()  
    {
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}

