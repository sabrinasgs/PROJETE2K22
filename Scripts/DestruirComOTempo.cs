using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComOTempo : MonoBehaviour
// Destruir com o tempo o laser das naves, para não pesar nosso jogo
{
    public float tempoVida;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
