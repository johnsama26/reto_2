using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionFin : MonoBehaviour

{
    //public int nextScene;
    public GameObject transition;
    public float transitionDuration = 1.0f;
    IEnumerator LoadNextSceneWithTransition()
    {
        transition.SetActive(true); // Activamos la transici�n antes de cargar el nivel

        yield return new WaitForSeconds(transitionDuration); // Esperamos por el tiempo de la transici�n

        //SceneManager.LoadScene(nextScene); // Cargamos el siguiente nivel



        // Si deseas guardar el progreso del nivel, hazlo aqu� despu�s de cargar el siguiente nivel.
        //if (nextScene > PlayerPrefs.GetInt("nivel"))
        {
            //PlayerPrefs.SetInt("nivel", nextScene);
            //Debug.Log("paso por aca");
        }
    }
}

    
