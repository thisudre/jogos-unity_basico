using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaBala : MonoBehaviour
{
    public float velocidadeDaBala = 25;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + transform.forward * velocidadeDaBala * Time.deltaTime
        );
    }
}
