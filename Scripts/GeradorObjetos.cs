using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObjetos : MonoBehaviour
{
    public GameObject[] objetosParaSpawnar;
    public Transform[] pontosSpawn;
    //Array é uma variavel que armazena diversas valores do mesmo tipo, ao mesmo tempo
    //Array é representada por []
    public float tempoMaxEntreSpawn;
    public float tempoAtualDosSpawn;

    // Start is called before the first frame update
    void Start()
    {
        tempoAtualDosSpawn = tempoMaxEntreSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualDosSpawn -= Time.deltaTime; 
        if(tempoAtualDosSpawn <= 0)
        {
            SpawnarObjetos();
        }
    }

    private void SpawnarObjetos()
    {
        int objetoAleatorio = Random.Range(0, objetosParaSpawnar.Length);
        int pontoAleatorio = Random.Range(0, pontosSpawn.Length);

        Instantiate(objetosParaSpawnar[objetoAleatorio], pontosSpawn[pontoAleatorio].position, Quaternion.Euler(0f, 0f, 90f));
        tempoAtualDosSpawn = tempoMaxEntreSpawn;
    }
}
