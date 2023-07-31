using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
   {
    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Comprueba si el jugador ha colisionado con el objeto desencadenador
        if (other.CompareTag("Player"))
        {
            // Carga la siguiente escena por su nombre
            SceneManager.LoadScene(nextLevelName);
        }
    }
}