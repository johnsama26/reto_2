using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collecbattery : MonoBehaviour
{
    public AudioSource collected;
    private int Bateria = 0;
    

    [SerializeField] private TextMeshProUGUI frutasText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bateria"))
        {
            collected.Play();
            Destroy(collision.gameObject);
            Bateria++;
            frutasText.text = "Coleccionable: " + Bateria;
        }
    }
}
