﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaCamera : MonoBehaviour
{
    public GameObject Jogador;
    Vector3 afastamento;
    // Start is called before the first frame update
    void Start()
    {
        afastamento = transform.position - Jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jogador.transform.position + afastamento;
    }
}
