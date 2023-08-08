using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaerAlColisionar : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static; // Empezamos con el Rigidbody inactivo
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Cambiamos a Rigidbody dinámico para que caiga
        }
    }
}
