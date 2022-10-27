using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserJogador : MonoBehaviour
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
        transform.Translate(Vector3.right * velocidadeLaser * Time.deltaTime); 
        //Time.deltaTime garante que a velocidade seja a mesma, independente se o pc for ou não for bom
    }

    void OnTriggerEnter2D(Collider2D other) //Verificar se algo colidiu com o ontrigger do laser (do jogador)
    {
        if(other.gameObject.CompareTag("Inimigo")) //Verifica se foi o inimigo que colidiu
        {
            other.gameObject.GetComponent<Inimigos>().MachucarInimigo(danoParaDar); //Acessa o script inimigo e ir para o metodo MachucarInimigo
            EfeitosSonoros.instance.somDeImpacto.Play();
            Destroy(this.gameObject); //Destruir o inimigo
        }
    }

}
