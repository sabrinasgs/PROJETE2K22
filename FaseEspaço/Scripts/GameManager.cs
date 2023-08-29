
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour //Gerenciador do jogo
{
    
    public static GameManager instance; 
    //public static é uma variavel unica
    //Instance é para fazer referencia ao mesmo script
    
    public Text textoPontuacaoAtual; 
    public GameObject painelGameOver;
    public Text textoPontuacaoFinal;
    public Text textoHighScore; 
    public int PontuacaoAtual; 

    void Awake() //Awake é o primeiro metodo a ser rodado
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f; 
        PontuacaoAtual = 0;
        textoPontuacaoAtual.text = "PONTUAÇÃO: " + PontuacaoAtual;
    }



    public void AumentarPontuacao(int pontosParaGanhar)
    {
        PontuacaoAtual += pontosParaGanhar;
        textoPontuacaoAtual.text = "PONTUAÇÃO: " + PontuacaoAtual;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        //Time.timeScale controla a velocidade do jogo

        painelGameOver.SetActive(true);
        //SetActive ativa o gameObject
        textoPontuacaoFinal.text = "PONTUAÇÃO: " + PontuacaoAtual;

        if(PontuacaoAtual > PlayerPrefs.GetInt("HighScore"))
        //PlayerPrefs salva algo na Unity
        //GetInt acessa um valor 
        {
            PlayerPrefs.SetInt("HighScore", PontuacaoAtual);
            //SetInt acessa um valor e tbem atribui 
        }

        textoHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");

    }
}

    
