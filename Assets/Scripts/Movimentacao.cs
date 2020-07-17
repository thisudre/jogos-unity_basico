using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade = 10;
    Vector3 direcao;
    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);


        // transform.Translate(direcao * Time.deltaTime * velocidade);

        if (direcao!=Vector3.zero)
        {
            GetComponent<Animator>().SetBool("movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("movendo", false);
        }
    }

    void FixedUpdate(){
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + (direcao * Time.deltaTime * velocidade)
        );
    }
}
