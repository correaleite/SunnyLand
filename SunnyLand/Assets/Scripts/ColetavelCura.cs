using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColetavelCura : MonoBehaviour

{
    public TMP_Text texto_vidas;
    public ParticleSystem efeitoC;
    public GameManager gameManager;
   

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            if (gameManager.vidas > 4) {
                return;
            } else { 
            gameManager.Heal(1);
            Instantiate(efeitoC, transform.position, Quaternion.identity);
           
            }
        }
    }

}