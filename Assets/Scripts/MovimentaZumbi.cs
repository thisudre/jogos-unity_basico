using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaZumbi : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;

    void FixedUpdate()
    {
        Vector3 direcao = Jogador.transform.position - transform.position;
        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);
        if (distancia > 2.5)
        {
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + direcao.normalized * Velocidade * Time.deltaTime
        );
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }

    }
}
