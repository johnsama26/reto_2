using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel1 : MonoBehaviour
{
    public GameObject transition;
    public float transitionDuration = 1.0f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Findeljuego");
        }
        IEnumerator LoadNextSceneWithTransition()
        {
            transition.SetActive(true); // Activamos la transición antes de cargar el nivel

            yield return new WaitForSeconds(transitionDuration);
        }
    }
}