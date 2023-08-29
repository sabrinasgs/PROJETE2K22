using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) // manipulação do componente colisor da Unity
    {
        if(collider.gameObject.layer == 7) 
        {
            Destroy(gameObject); // coleta o objeto
        }
    }
}
