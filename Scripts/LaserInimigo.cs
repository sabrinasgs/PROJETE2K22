using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserInimigo : MonoBehaviour
{
    public float velocidadeLaser;
    public int danoParaDar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.up * velocidadeLaser * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) //Verifica se algo colidiu
    {
        if(other.gameObject.CompareTag("Player")) //Verefica se é a nave do jogador
        {
            other.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoParaDar);
            //Acessa o script de vida de jogador e da dano nele
            Destroy(this.gameObject);
        }
    }
}
