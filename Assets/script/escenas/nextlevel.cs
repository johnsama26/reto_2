using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public int nextScene;
    public GameObject transition;
    public float transitionDuration = 1.0f;

    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(LoadNextSceneWithTransition());
        }
    }

    IEnumerator LoadNextSceneWithTransition()
    {
        transition.SetActive(true); // Activamos la transición antes de cargar el nivel

        yield return new WaitForSeconds(transitionDuration); // Esperamos por el tiempo de la transición

        SceneManager.LoadScene(nextScene); // Cargamos el siguiente nivel



        // Si deseas guardar el progreso del nivel, hazlo aquí después de cargar el siguiente nivel.
        if (nextScene > PlayerPrefs.GetInt("nivel"))
        {
            PlayerPrefs.SetInt("nivel", nextScene);
            Debug.Log("paso por aca");
        }
    }
}