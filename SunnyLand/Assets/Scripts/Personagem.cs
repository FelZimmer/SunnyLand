using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private int vidaInicial = 10;
    private float velocidade = 2.5f;
    private bool vivoMorto = true;
    private Rigidbody2D rb;
    private float NovaGravidade=0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("jogo começou, vc tem:\n"+ "Vida Inicial: \n" + vidaInicial + "\n velocidade: " + velocidade + "\n vivoMorto: " + vivoMorto);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.1f;
    }

    // Update is called once per frame
    void Update() {

        Debug.Log("Vida Inicial: \n" + vidaInicial + "\n velocidade: " + velocidade + "\n vivoMorto: " + vivoMorto);
        

        }
    }
