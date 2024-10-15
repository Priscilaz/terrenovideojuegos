using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoChanchito : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Movimiento con las teclas WASD o las flechas
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
