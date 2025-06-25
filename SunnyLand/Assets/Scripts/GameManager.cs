using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int vidas = 0;
    public TMP_Text texto_vidas;
    public ParticleSystem efeitoC;
    public ParticleSystem efeitoD;

    int score = 0;
    public TMP_Text texto_pontos;   
    public ParticleSystem efeitoP;


    public void AddPoints(int pontos) {
        score += pontos;
        texto_pontos.text = "Pontos:" + score.ToString();


    }

    public void Heal(int life)
    {
        vidas += life;
        texto_vidas.text = " " + vidas.ToString();

    }

    public void RemoveLife(int life)
    {
        vidas -= life;
        texto_vidas.text = " " + vidas.ToString();

    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
