using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectable : MonoBehaviour
{
    public TMP_Text texto_pontos;
    public ParticleSystem efeitoP;
public GameManager gameManager;

    private bool foiColetado = false;




    private void OnTriggerEnter2D(Collider2D outro)
    {

        if (outro.CompareTag("Player"))

            {
            if (foiColetado) return;
            foiColetado =true;
            gameManager.AddPoints(1);
            outro.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeitoP, transform.position, Quaternion.identity);
            Destroy(gameObject);
            }

        
    }
    

}
