using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coletavel : MonoBehaviour


{
    public TMP_Text texto_pontuacao;

    // Start is called before the first frame update
    public ParticleSystem efeito;
    private int pontos = 0;
    void Start()
    {
        Debug.Log("jogo começou, vc tem:\n" + pontos + "pontos!");
    //Debug.Log("jogo começou");

}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("jogo rodando");

    }

    


    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            Debug.Log("Bateu");
            outro.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity );
            pontos++;
            texto_pontuacao.text = "pontos:" + pontos.ToString();
            Destroy(gameObject);
        }
    }


}
