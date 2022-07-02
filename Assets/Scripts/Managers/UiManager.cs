using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Variaveis
    [SerializeField] private GameObject canvasMenu;
    [SerializeField] private GameObject mainMenuUi;
    [SerializeField] private GameObject mainMenuBackground;
    [SerializeField] private GameObject mainMenuCamera;
    [Space]
    [SerializeField] private GameObject canvasGameplay;
    [SerializeField] private GameObject gameOverUi;
    [SerializeField] private GameObject winUi;
    // Esconde o menu principal
    public void HiddeMainMenu()
    {
        canvasMenu.SetActive(false);
        mainMenuUi.SetActive(false);
        mainMenuBackground.SetActive(false);
        mainMenuCamera.SetActive(false);
        Cursor.visible = false;
    }
    public void ShowMainMenu()
    {
        mainMenuCamera.SetActive(true);
        mainMenuBackground.SetActive(true);
        canvasMenu.SetActive(true);
        mainMenuUi.SetActive(true);
        Cursor.visible = true;
    }
    public void ShowGameOver()
    {
        canvasGameplay.SetActive(true);
        gameOverUi.SetActive(true);
        winUi.SetActive(false);
        Cursor.visible = true;
    }
    public void HiddeGameOver()
    {
        canvasGameplay.SetActive(false);
        gameOverUi.SetActive(false);
    }
    public void ShowWin()
    {
        canvasGameplay.SetActive(true);
        gameOverUi.SetActive(false);
        winUi.SetActive(true);
        Cursor.visible = true;
    }
}
