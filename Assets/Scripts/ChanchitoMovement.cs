using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanchitoMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidad de movimiento ajustable
    public float turnSpeed = 10f; // Velocidad de giro

    void Update()
    {
        // Obtenemos el input de las teclas
        float moveX = Input.GetAxis("Horizontal"); // Teclas A/D o Izquierda/Derecha
        float moveZ = Input.GetAxis("Vertical");   // Teclas W/S o Arriba/Abajo

        // Movemos al chanchito hacia adelante o atrás (Z) en su propia dirección
        Vector3 moveDirection = transform.forward * moveZ * moveSpeed * Time.deltaTime;

        // Aplicamos el movimiento
        transform.Translate(moveDirection, Space.World);

        // Rotamos el chanchito según la tecla A/D (horizontal)
        if (moveX != 0)
        {
            transform.Rotate(0, moveX * turnSpeed * Time.deltaTime, 0);
        }
    }
}
