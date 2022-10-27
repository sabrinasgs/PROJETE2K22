// Canal de referencia: Desenvolvendo jogos
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D; 
    public GameObject laserJogador; //tipo gameobject, pois criamos um gameobject na unity
    public Transform localDisparo; //tipo transform pois quer pegar um local na unity
    public float velocidadeNave; //variavel publica, para mexer na unity. Tipo float por ser valor quebrado
    private Vector2 teclasApertadas; // variavel privada, nao vai aparecer na unity. Tipo Vector2, pois pega o eixo x e y

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
        AtirarLaser();
    }

    private void MovimentarJogador() //metodo
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeNave;
    }

    private void AtirarLaser()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserJogador, localDisparo.position, localDisparo.rotation);
            EfeitosSonoros.instance.somLaserJogador.Play();
        }
    }
}
