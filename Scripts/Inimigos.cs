using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public GameObject laserInimigo; 
    public GameObject itemParaDropar;
    public Transform localDisparo;
    public float velocidadeInimigo;
    public int vidaMaxInimigo;
    public int vidaAtualInimigo;
    public int pontosParaDar; 
    public int chanceParaDropar;
    public float tempoMaxEntreLasers;
    public float tempoAtualLasers;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualInimigo = vidaMaxInimigo;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarInimigo();
        AtirarLaser();

    }

    private void MovimentarInimigo()
    {
        transform.Translate(Vector3.up * velocidadeInimigo * Time.deltaTime);
    }

    private void AtirarLaser()
    {
        tempoAtualLasers -= Time.deltaTime;
        if(tempoAtualLasers <= 0)
        {
            Instantiate(laserInimigo, localDisparo.position, Quaternion.Euler(0f, 0f, 90f));
            //Na mat, tudo funciona com 4 eixos. Porém a unity tranforma em tres, chamando de Quartenion.Euler, converte 4 eixos em 3
            tempoAtualLasers = tempoMaxEntreLasers;
        }
    }

    public void MachucarInimigo(int danoParaReceber)
   {
        vidaAtualInimigo -= danoParaReceber;
        if(vidaAtualInimigo <= 0)      
        {
            int numeroAleatorio = Random.Range(0, 3);

            if(numeroAleatorio <= chanceParaDropar)
            {
                Instantiate(itemParaDropar, transform.position, Quaternion.Euler(0f, 0f, 0f));
                
            }
            GameManager.instance.AumentarPontuacao(pontosParaDar);
            Destroy(this.gameObject);
        } 
   }

      
}
 

