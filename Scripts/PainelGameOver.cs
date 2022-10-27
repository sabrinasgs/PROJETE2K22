using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PainelGameOver : MonoBehaviour
{
    public Transform MenudeGameOver;
    public string nomeDaCenaAtual;
     void Start () 
    {
   }

    public void ReiniciarGame()
    {
        SceneManager.LoadScene(nomeDaCenaAtual);
        Time.timeScale = 1f; 
    }

    public void ChamarJogoMemoria()
    {
        SceneManager.LoadScene("JogoDaMemoria");
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
}
