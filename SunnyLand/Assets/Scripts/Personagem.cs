using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome = "Raulzito";
    public float velocidade = 2.5f;
    public bool vivo = true;
    private Rigidbody2D rb;
    public float novaGravidade = 0;
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
