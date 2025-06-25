using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetavelVelocidade : MonoBehaviour

{
    public ParticleSystem efeitoV;
    public PlayerMovement playerMovement;
    

    private void OnTriggerEnter2D(Collider2D outro)
    {
        playerMovement.runSpeed = 100f;
        Instantiate(efeitoV, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}