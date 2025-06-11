using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome = "Raulzito";
    public int vida = 3;
    public float velocidade = 2.5f;
    public bool vivo = true;
    private Rigidbody2D rb;
    public float novaGravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
        Debug.Log($"Personagem:\n Nome: {nome} \n Vida: {vida} \n velocidade: {velocidade} \n Vivo: {vivo} "  );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
