using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;

    public void Play()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Exit()
    {

        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
