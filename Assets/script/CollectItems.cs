using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{

    private int frutas = 0;

 
    [SerializeField] private TextMeshProUGUI frutasText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("frutas"))
        {
            Destroy(collision.gameObject);
            frutas++;
            frutasText.text = "frutas: " + frutas;
        }
    }
}
