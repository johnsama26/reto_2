using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaAlColisionar : MonoBehaviour
{
    public string nombreEscenaACambiar = "NuevaEscena";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nombreEscenaACambiar);
        }
    }
}
