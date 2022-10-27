using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class VidaDoJogador : MonoBehaviour
{
    public Slider barraVida; 
    public int vidaMaxJogador;
    public int vidaAtualJogador;
    public GameObject botaoMemoria;
    int cartasColetadas = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaAtualJogador = vidaMaxJogador;
        barraVida.maxValue = vidaMaxJogador;
        barraVida.value = vidaAtualJogador;
    }

    // Update is called once per frame
    public void MachucarJogador(int danoParaReceber)
    {
        vidaAtualJogador -= danoParaReceber;
        barraVida.value = vidaAtualJogador;

        if(vidaAtualJogador <= 0)
        {
            GameManager.instance.GameOver();
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if(collisionInfo.gameObject.layer == 6)
        {
            cartasColetadas++;

            if(cartasColetadas == 5)
            {
                botaoMemoria.SetActive(true);
            }
            Debug.Log(cartasColetadas);
        }

    }
}
