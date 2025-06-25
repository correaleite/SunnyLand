using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColetavelVelocidade : MonoBehaviour

{
    
    public ParticleSystem efeitoV;
    public GameManager gameManager;
    int  velocidade = 0;
    private bool foiColetado = false;
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            if (foiColetado) return;
            foiColetado = true;
            gameManager.Heal(1);
            
            Instantiate(efeitoV, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
