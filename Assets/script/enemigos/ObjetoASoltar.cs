using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ObjetoASoltar : MonoBehaviour
{
    public AudioSource collected;
    private int particula = 0;

    [SerializeField] private TextMeshProUGUI particulaText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Cambia "Jugador" por la etiqueta correcta del objeto que recogerá las frutas.
        {
            //collected.Play();
            Destroy(gameObject); // Destruye el objeto después de ser recogido.
            particula++;
            //particulaText.text = "Particula: " + particula;
        }
    }

    internal void SetCollectedSound(AudioSource collected)
    {
        throw new NotImplementedException();
    }
}