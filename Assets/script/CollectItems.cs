using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    public AudioSource collected;
    private int frutas = 0;
    private int Bateria = 0;

    [SerializeField] private TextMeshProUGUI frutasText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("frutas"))
        {
            collected.Play();
            Destroy(collision.gameObject);
            frutas++;
            frutasText.text = "Score: " + frutas;
        }
    }
}
