using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variaveis
    [SerializeField] private GameObject mazeManager;
    [SerializeField] private GameObject uiManager;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerCamera;
    Animator animator;
    private bool isPlayerDead;
    private bool isPlayerWinner;

    private void Awake()
    {
        animator = player.GetComponent<Animator>();
        isPlayerDead = false;
        isPlayerWinner = false;
        mazeManager.SetActive(false);
        player.SetActive(false);
        playerCamera.SetActive(false);
        uiManager.GetComponent<UiManager>().ShowMainMenu();
    }
    // Fecha o jogo
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Inicia o jogo
    public void StartGame(){
        mazeManager.SetActive(true);
        player.SetActive(true);
        playerCamera.SetActive(true);
        uiManager.GetComponent<UiManager>().HiddeMainMenu();
    }
    // Define que o jogador foi morto
    public void SetPlayerDeath(){
        isPlayerDead = true;
    }
    public void SetPlayerWin(){
        isPlayerWinner = true;
    }
    private IEnumerator BadEndGame(){
        player.GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = false;
        animator.SetBool("isDead", true);
        yield return new WaitForSeconds(1.5f);
        uiManager.GetComponent<UiManager>().ShowGameOver();
    }
    private IEnumerator GoodEndGame(){
        player.GetComponent<Invector.vCharacterController.vThirdPersonInput>().enabled = false;
        animator.SetBool("isWin", true);
        yield return new WaitForSeconds(1.5f);
        uiManager.GetComponent<UiManager>().ShowWin();
    }
    // Verifica se o jogador esta morto
    private void Update(){
        if(isPlayerDead && !isPlayerWinner)
        {
            StartCoroutine(BadEndGame());
        }
        if(!isPlayerDead && isPlayerWinner)
        {
            StartCoroutine(GoodEndGame());
        }
    }
}
