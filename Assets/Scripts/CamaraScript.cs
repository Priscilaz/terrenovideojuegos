using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform chanchito;  // Referencia al objeto "Chanchito"
    public float distance = 5f;  // Distancia detr�s del chanchito
    public float height = 3f;    // Altura sobre el chanchito
    public float followSpeed = 5f; // Velocidad con la que sigue al chanchito

    void LateUpdate()
    {
        // Calculamos la posici�n detr�s y sobre el chanchito
        Vector3 targetPosition = chanchito.position - chanchito.forward * distance + Vector3.up * height;

        // Movemos la c�mara suavemente hacia la posici�n objetivo
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // La c�mara siempre mira hacia el chanchito
        transform.LookAt(chanchito);
    }
}
