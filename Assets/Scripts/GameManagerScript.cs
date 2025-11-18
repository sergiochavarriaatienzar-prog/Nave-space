using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    public GameObject gameOverUI;

    void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        UnityEngine.Debug.Log("GAME OVER");
        gameOverUI.SetActive(true);

        // Pausa el juego
        Time.timeScale = 0f;
    }
}
