using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColetavelDano : MonoBehaviour
{
    public TMP_Text texto_vidas;
    public ParticleSystem efeitoD;
    public GameManager gameManager;
    int vidas = 0;
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            gameManager.RemoveLife(1);
            Instantiate(efeitoD, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
